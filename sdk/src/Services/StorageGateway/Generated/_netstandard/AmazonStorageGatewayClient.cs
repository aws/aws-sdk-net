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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.StorageGateway.Model;
using Amazon.StorageGateway.Model.Internal.MarshallTransformations;
using Amazon.StorageGateway.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.StorageGateway
{
    /// <summary>
    /// <para>Implementation for accessing StorageGateway</para>
    ///
    /// Storage Gateway Service <important> 
    /// <para>
    /// Amazon FSx File Gateway is no longer available to new customers. Existing customers
    /// of FSx File Gateway can continue to use the service normally. For capabilities similar
    /// to FSx File Gateway, visit <a href="https://aws.amazon.com/blogs/storage/switch-your-file-share-access-from-amazon-fsx-file-gateway-to-amazon-fsx-for-windows-file-server/">this
    /// blog post</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Storage Gateway is the service that connects an on-premises software appliance with
    /// cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and the Amazon Web Services storage infrastructure. The
    /// service enables you to securely upload data to the Amazon Web Services Cloud for cost
    /// effective backup and rapid disaster recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>Storage Gateway Service API Reference</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewayHTTPRequestsHeaders">Storage
    /// Gateway required request headers</a>: Describes the required headers that you must
    /// send with every POST request to Storage Gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewaySigningRequests">Signing
    /// requests</a>: Storage Gateway requires that you authenticate every request you send;
    /// this topic describes how sign such a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#APIErrorResponses">Error
    /// responses</a>: Provides reference information about Storage Gateway errors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_Operations.html">Operations
    /// in Storage Gateway</a>: Contains detailed descriptions of all Storage Gateway operations,
    /// their request parameters, response elements, possible errors, and examples of requests
    /// and responses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">Storage Gateway endpoints
    /// and quotas</a>: Provides a list of each Amazon Web Services Region and the endpoints
    /// available for use with Storage Gateway.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Storage Gateway resource IDs are in uppercase. When you use these resource IDs with
    /// the Amazon EC2 API, EC2 expects resource IDs in lowercase. You must change your resource
    /// ID to lowercase to use it with the EC2 API. For example, in Storage Gateway the ID
    /// for a volume might be <c>vol-AA22BB012345DAF670</c>. When you use this ID with the
    /// EC2 API, you must change it to <c>vol-aa22bb012345daf670</c>. Otherwise, the EC2 API
    /// might not behave as expected.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// IDs for Storage Gateway volumes and Amazon EBS snapshots created from gateway volumes
    /// are changing to a longer format. Starting in December 2016, all new volumes and snapshots
    /// will be created with a 17-character string. Starting in April 2016, you will be able
    /// to use these longer IDs so you can test your systems with the new format. For more
    /// information, see <a href="http://aws.amazon.com/ec2/faqs/#longer-ids">Longer EC2 and
    /// EBS resource IDs</a>.
    /// </para>
    ///  
    /// <para>
    /// For example, a volume Amazon Resource Name (ARN) with the longer volume ID format
    /// looks like the following:
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:storagegateway:us-west-2:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABBCCDDEEFFG</c>.
    /// </para>
    ///  
    /// <para>
    /// A snapshot ID with the longer ID format looks like the following: <c>snap-78e226633445566ee</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://forums.aws.amazon.com/ann.jspa?annID=3557">Announcement:
    /// Heads-up – Longer Storage Gateway volume and snapshot IDs coming in 2016</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AmazonStorageGatewayClient : AmazonServiceClient, IAmazonStorageGateway
    {
        private static IServiceMetadata serviceMetadata = new AmazonStorageGatewayMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
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
        public AmazonStorageGatewayClient()
            : base(new AmazonStorageGatewayConfig()) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
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
        public AmazonStorageGatewayClient(RegionEndpoint region)
            : base(new AmazonStorageGatewayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AmazonStorageGatewayConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonStorageGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Credentials and an
        /// AmazonStorageGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(AWSCredentials credentials, AmazonStorageGatewayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStorageGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStorageGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStorageGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStorageGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonStorageGatewayClient Configuration Object</param>
        public AmazonStorageGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonStorageGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IStorageGatewayPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IStorageGatewayPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new StorageGatewayPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonStorageGatewayEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonStorageGatewayAuthSchemeHandler());
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


        #region  ActivateGateway

        internal virtual ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return Invoke<ActivateGatewayResponse>(request, options);
        }



        /// <summary>
        /// Activates the gateway you previously deployed on your host. In the activation process,
        /// you specify information such as the Amazon Web Services Region that you want to use
        /// for storing snapshots or tapes, the time zone for scheduled snapshots the gateway
        /// snapshot schedule window, an activation key, and a name for your gateway. The activation
        /// process also associates your gateway with your account. For more information, see
        /// <a>UpdateGatewayInformation</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must turn on the gateway VM before you can activate your gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ActivateGateway">REST API Reference for ActivateGateway Operation</seealso>
        public virtual Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddCache

        internal virtual AddCacheResponse AddCache(AddCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCacheResponseUnmarshaller.Instance;

            return Invoke<AddCacheResponse>(request, options);
        }



        /// <summary>
        /// Configures one or more gateway local disks as cache for a gateway. This operation
        /// is only supported in the cached volume, tape, and file gateway type (see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">How
        /// Storage Gateway works (architecture)</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddCache">REST API Reference for AddCache Operation</seealso>
        public virtual Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCacheResponseUnmarshaller.Instance;

            return InvokeAsync<AddCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
        /// which you can use to categorize these resources. For example, you can categorize resources
        /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
        /// you define. You can add tags to the following Storage Gateway resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Storage gateways of all types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Storage volumes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Virtual tapes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NFS and SMB file shares
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File System associations
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a maximum of 50 tags for each resource. Virtual tapes and storage volumes
        /// that are recovered to a new gateway maintain their tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddUploadBuffer

        internal virtual AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return Invoke<AddUploadBufferResponse>(request, options);
        }



        /// <summary>
        /// Configures one or more gateway local disks as upload buffer for a specified gateway.
        /// This operation is supported for the stored volume, cached volume, and tape gateway
        /// types.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add upload buffer, and one or more disk IDs that you want to configure as upload
        /// buffer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddUploadBuffer">REST API Reference for AddUploadBuffer Operation</seealso>
        public virtual Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<AddUploadBufferResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddWorkingStorage

        internal virtual AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<AddWorkingStorageResponse>(request, options);
        }



        /// <summary>
        /// Configures one or more gateway local disks as working storage for a gateway. This
        /// operation is only supported in the stored volume gateway type. This operation is deprecated
        /// in cached volume API version 20120630. Use <a>AddUploadBuffer</a> instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the <a>AddUploadBuffer</a>
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddWorkingStorage">REST API Reference for AddWorkingStorage Operation</seealso>
        public virtual Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<AddWorkingStorageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssignTapePool

        internal virtual AssignTapePoolResponse AssignTapePool(AssignTapePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssignTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignTapePoolResponseUnmarshaller.Instance;

            return Invoke<AssignTapePoolResponse>(request, options);
        }



        /// <summary>
        /// Assigns a tape to a tape pool for archiving. The tape assigned to a pool is archived
        /// in the S3 storage class that is associated with the pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the S3 storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AssignTapePool">REST API Reference for AssignTapePool Operation</seealso>
        public virtual Task<AssignTapePoolResponse> AssignTapePoolAsync(AssignTapePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssignTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignTapePoolResponseUnmarshaller.Instance;

            return InvokeAsync<AssignTapePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateFileSystem

        internal virtual AssociateFileSystemResponse AssociateFileSystem(AssociateFileSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFileSystemResponseUnmarshaller.Instance;

            return Invoke<AssociateFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Associate an Amazon FSx file system with the FSx File Gateway. After the association
        /// process is complete, the file shares on the Amazon FSx file system are available for
        /// access through the gateway. This operation only supports the FSx File Gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFileSystem service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AssociateFileSystem">REST API Reference for AssociateFileSystem Operation</seealso>
        public virtual Task<AssociateFileSystemResponse> AssociateFileSystemAsync(AssociateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFileSystemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AttachVolume

        internal virtual AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeResponse>(request, options);
        }



        /// <summary>
        /// Connects a volume to an iSCSI connection and then attaches the volume to the specified
        /// gateway. Detaching and attaching a volume enables you to recover your data from one
        /// gateway to a different gateway without creating a snapshot. It also makes it easier
        /// to move your volumes from an on-premises gateway to a gateway hosted on an Amazon
        /// EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public virtual Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelArchival

        internal virtual CancelArchivalResponse CancelArchival(CancelArchivalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelArchivalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return Invoke<CancelArchivalResponse>(request, options);
        }



        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated. This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelArchival">REST API Reference for CancelArchival Operation</seealso>
        public virtual Task<CancelArchivalResponse> CancelArchivalAsync(CancelArchivalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelArchivalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelArchivalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelCacheReport

        internal virtual CancelCacheReportResponse CancelCacheReport(CancelCacheReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCacheReportResponseUnmarshaller.Instance;

            return Invoke<CancelCacheReportResponse>(request, options);
        }



        /// <summary>
        /// Cancels generation of a specified cache report. You can use this operation to manually
        /// cancel an IN-PROGRESS report for any reason. This action changes the report status
        /// from IN-PROGRESS to CANCELLED. You can only cancel in-progress reports. If the the
        /// report you attempt to cancel is in FAILED, ERROR, or COMPLETED state, the cancel operation
        /// returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCacheReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCacheReport service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelCacheReport">REST API Reference for CancelCacheReport Operation</seealso>
        public virtual Task<CancelCacheReportResponse> CancelCacheReportAsync(CancelCacheReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCacheReportResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCacheReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelRetrieval

        internal virtual CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return Invoke<CancelRetrievalResponse>(request, options);
        }



        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelRetrieval">REST API Reference for CancelRetrieval Operation</seealso>
        public virtual Task<CancelRetrievalResponse> CancelRetrievalAsync(CancelRetrievalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelRetrievalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCachediSCSIVolume

        internal virtual CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateCachediSCSIVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates a cached volume on a specified cached volume gateway. This operation is only
        /// supported in the cached volume gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a cached volume.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
        /// target name, an IP address on which to expose the target, and a unique client token.
        /// In response, the gateway creates the volume and returns information about it. This
        /// information includes the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can provide the ARN for an existing volume as the <c>SourceVolumeARN</c>
        /// for this cached volume, which creates an exact copy of the existing volume’s latest
        /// recovery point. The <c>VolumeSizeInBytes</c> value must be equal to or larger than
        /// the size of the copied volume, in bytes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateCachediSCSIVolume">REST API Reference for CreateCachediSCSIVolume Operation</seealso>
        public virtual Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCachediSCSIVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateNFSFileShare

        internal virtual CreateNFSFileShareResponse CreateNFSFileShare(CreateNFSFileShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<CreateNFSFileShareResponse>(request, options);
        }



        /// <summary>
        /// Creates a Network File System (NFS) file share on an existing S3 File Gateway. In
        /// Storage Gateway, a file share is a file system mount point backed by Amazon S3 cloud
        /// storage. Storage Gateway exposes file shares using an NFS interface. This operation
        /// is only supported for S3 File Gateways.
        /// 
        ///  <important> 
        /// <para>
        /// S3 File gateway requires Security Token Service (Amazon Web Services STS) to be activated
        /// to enable you to create a file share. Make sure Amazon Web Services STS is activated
        /// in the Amazon Web Services Region you are creating your S3 File Gateway in. If Amazon
        /// Web Services STS is not activated in the Amazon Web Services Region, activate it.
        /// For information about how to activate Amazon Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Identity and Access Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// S3 File Gateways do not support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNFSFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateNFSFileShare">REST API Reference for CreateNFSFileShare Operation</seealso>
        public virtual Task<CreateNFSFileShareResponse> CreateNFSFileShareAsync(CreateNFSFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNFSFileShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSMBFileShare

        internal virtual CreateSMBFileShareResponse CreateSMBFileShare(CreateSMBFileShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMBFileShareResponseUnmarshaller.Instance;

            return Invoke<CreateSMBFileShareResponse>(request, options);
        }



        /// <summary>
        /// Creates a Server Message Block (SMB) file share on an existing S3 File Gateway. In
        /// Storage Gateway, a file share is a file system mount point backed by Amazon S3 cloud
        /// storage. Storage Gateway exposes file shares using an SMB interface. This operation
        /// is only supported for S3 File Gateways.
        /// 
        ///  <important> 
        /// <para>
        /// S3 File Gateways require Security Token Service (Amazon Web Services STS) to be activated
        /// to enable you to create a file share. Make sure that Amazon Web Services STS is activated
        /// in the Amazon Web Services Region you are creating your S3 File Gateway in. If Amazon
        /// Web Services STS is not activated in this Amazon Web Services Region, activate it.
        /// For information about how to activate Amazon Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Identity and Access Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSMBFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSMBFileShare">REST API Reference for CreateSMBFileShare Operation</seealso>
        public virtual Task<CreateSMBFileShareResponse> CreateSMBFileShareAsync(CreateSMBFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMBFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSMBFileShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// Storage Gateway provides the ability to back up point-in-time snapshots of your data
        /// to Amazon Simple Storage (Amazon S3) for durable off-site recovery, and also import
        /// the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute Cloud
        /// (EC2). You can take snapshots of your gateway volume on a scheduled or ad hoc basis.
        /// This API enables you to take an ad hoc snapshot. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#SchedulingSnapshot">Editing
        /// a snapshot schedule</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <c>CreateSnapshot</c> request, you identify the volume by providing its Amazon
        /// Resource Name (ARN). You must also provide description for the snapshot. When Storage
        /// Gateway takes the snapshot of specified volume, the snapshot and description appears
        /// in the Storage Gateway console. In response, Storage Gateway returns you a snapshot
        /// ID. You can use this snapshot ID to check the snapshot progress or later use it when
        /// you want to create a volume from a snapshot. This operation is only supported in stored
        /// and cached volume gateway type.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Volume and snapshot IDs are changing to a longer length ID format. For more information,
        /// see the important note on the <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/Welcome.html">Welcome</a>
        /// page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint

        internal virtual CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotFromVolumeRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
        /// only supported in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// A volume recovery point is a point in time at which all data of the volume is consistent
        /// and from which you can create a snapshot. To get a list of volume recovery point for
        /// cached volume gateway, use <a>ListVolumeRecoveryPoints</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <c>CreateSnapshotFromVolumeRecoveryPoint</c> request, you identify the volume
        /// by providing its Amazon Resource Name (ARN). You must also provide a description for
        /// the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
        /// and its description appear in the Storage Gateway console. In response, the gateway
        /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
        /// or later use it when you want to create a volume from a snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshotFromVolumeRecoveryPoint">REST API Reference for CreateSnapshotFromVolumeRecoveryPoint Operation</seealso>
        public virtual Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotFromVolumeRecoveryPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStorediSCSIVolume

        internal virtual CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateStorediSCSIVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates a volume on a specified gateway. This operation is only supported in the stored
        /// volume gateway type.
        /// 
        ///  
        /// <para>
        /// The size of the volume to create is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create
        /// an empty volume. If you choose to create an empty gateway volume, then any existing
        /// data on the disk is erased.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, the gateway creates the volume and returns volume
        /// information such as the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateStorediSCSIVolume">REST API Reference for CreateStorediSCSIVolume Operation</seealso>
        public virtual Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorediSCSIVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTapePool

        internal virtual CreateTapePoolResponse CreateTapePool(CreateTapePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapePoolResponseUnmarshaller.Instance;

            return Invoke<CreateTapePoolResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom tape pool. You can use custom tape pool to enable tape retention
        /// lock on tapes that are archived in the custom pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapePool">REST API Reference for CreateTapePool Operation</seealso>
        public virtual Task<CreateTapePoolResponse> CreateTapePoolAsync(CreateTapePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapePoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTapes

        internal virtual CreateTapesResponse CreateTapes(CreateTapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return Invoke<CreateTapesResponse>(request, options);
        }



        /// <summary>
        /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
        /// the tapes. This operation is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create virtual tapes.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapes">REST API Reference for CreateTapes Operation</seealso>
        public virtual Task<CreateTapesResponse> CreateTapesAsync(CreateTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTapeWithBarcode

        internal virtual CreateTapeWithBarcodeResponse CreateTapeWithBarcode(CreateTapeWithBarcodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return Invoke<CreateTapeWithBarcodeResponse>(request, options);
        }



        /// <summary>
        /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
        /// and then archive the tape. A barcode is unique and cannot be reused if it has already
        /// been used on a tape. This applies to barcodes used on deleted tapes. This operation
        /// is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a virtual tape.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapeWithBarcode service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapeWithBarcode">REST API Reference for CreateTapeWithBarcode Operation</seealso>
        public virtual Task<CreateTapeWithBarcodeResponse> CreateTapeWithBarcodeAsync(CreateTapeWithBarcodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapeWithBarcodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAutomaticTapeCreationPolicy

        internal virtual DeleteAutomaticTapeCreationPolicyResponse DeleteAutomaticTapeCreationPolicy(DeleteAutomaticTapeCreationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomaticTapeCreationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomaticTapeCreationPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomaticTapeCreationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the automatic tape creation policy of a gateway. If you delete this policy,
        /// new virtual tapes must be created manually. Use the Amazon Resource Name (ARN) of
        /// the gateway in your request to remove the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomaticTapeCreationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteAutomaticTapeCreationPolicy">REST API Reference for DeleteAutomaticTapeCreationPolicy Operation</seealso>
        public virtual Task<DeleteAutomaticTapeCreationPolicyResponse> DeleteAutomaticTapeCreationPolicyAsync(DeleteAutomaticTapeCreationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomaticTapeCreationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomaticTapeCreationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutomaticTapeCreationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBandwidthRateLimit

        internal virtual DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteBandwidthRateLimitResponse>(request, options);
        }



        /// <summary>
        /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
        /// download bandwidth rate limit, or you can delete both. If you delete only one of the
        /// limits, the other limit remains unchanged. To specify which gateway to work with,
        /// use the Amazon Resource Name (ARN) of the gateway in your request. This operation
        /// is supported only for the stored volume, cached volume, and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteBandwidthRateLimit">REST API Reference for DeleteBandwidthRateLimit Operation</seealso>
        public virtual Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBandwidthRateLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCacheReport

        internal virtual DeleteCacheReportResponse DeleteCacheReport(DeleteCacheReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheReportResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheReportResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified cache report and any associated tags from the Storage Gateway
        /// database. You can only delete completed reports. If the status of the report you attempt
        /// to delete still IN-PROGRESS, the delete operation returns an error. You can use <c>CancelCacheReport</c>
        /// to cancel an IN-PROGRESS report.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>DeleteCacheReport</c> does not delete the report object from your Amazon S3 bucket.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCacheReport service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteCacheReport">REST API Reference for DeleteCacheReport Operation</seealso>
        public virtual Task<DeleteCacheReportResponse> DeleteCacheReportAsync(DeleteCacheReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheReportResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChapCredentials

        internal virtual DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteChapCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target and initiator pair. This operation is supported in volume and tape gateway
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteChapCredentials">REST API Reference for DeleteChapCredentials Operation</seealso>
        public virtual Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChapCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFileShare

        internal virtual DeleteFileShareResponse DeleteFileShare(DeleteFileShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return Invoke<DeleteFileShareResponse>(request, options);
        }



        /// <summary>
        /// Deletes a file share from an S3 File Gateway. This operation is only supported for
        /// S3 File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteFileShare">REST API Reference for DeleteFileShare Operation</seealso>
        public virtual Task<DeleteFileShareResponse> DeleteFileShareAsync(DeleteFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGateway

        internal virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name
        /// (ARN) of the gateway in your request. The operation deletes the gateway; however,
        /// it does not delete the gateway virtual machine (VM) from your host computer.
        /// 
        ///  
        /// <para>
        /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
        /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
        /// not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.
        /// </para>
        ///  <important> 
        /// <para>
        /// You no longer pay software charges after the gateway is deleted; however, your existing
        /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
        /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
        /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">Storage
        /// Gateway detail page</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshotSchedule

        internal virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// You can take snapshots of your gateway volumes on a scheduled or ad hoc basis. This
        /// API action enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/backing-up-volumes.html">Backing
        /// up your volumes</a>. In the <c>DeleteSnapshotSchedule</c> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). This operation is only supported
        /// for cached volume gateway types.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// go to <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTape

        internal virtual DeleteTapeResponse DeleteTape(DeleteTapeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified virtual tape. This operation is only supported in the tape gateway
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTape">REST API Reference for DeleteTape Operation</seealso>
        public virtual Task<DeleteTapeResponse> DeleteTapeAsync(DeleteTapeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTapeArchive

        internal virtual DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeArchiveResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS). This operation
        /// is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapeArchive">REST API Reference for DeleteTapeArchive Operation</seealso>
        public virtual Task<DeleteTapeArchiveResponse> DeleteTapeArchiveAsync(DeleteTapeArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTapePool

        internal virtual DeleteTapePoolResponse DeleteTapePool(DeleteTapePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapePoolResponseUnmarshaller.Instance;

            return Invoke<DeleteTapePoolResponse>(request, options);
        }



        /// <summary>
        /// Delete a custom tape pool. A custom tape pool can only be deleted if there are no
        /// tapes in the pool and if there are no automatic tape creation policies that reference
        /// the custom tape pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapePool">REST API Reference for DeleteTapePool Operation</seealso>
        public virtual Task<DeleteTapePoolResponse> DeleteTapePoolAsync(DeleteTapePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTapePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapePoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified storage volume that you previously created using the <a>CreateCachediSCSIVolume</a>
        /// or <a>CreateStorediSCSIVolume</a> API. This operation is only supported in the cached
        /// volume and stored volume types. For stored volume gateways, the local disk that was
        /// configured as the storage volume is not deleted. You can reuse the local disk to create
        /// another storage volume.
        /// 
        ///  
        /// <para>
        /// Before you delete a volume, make sure there are no iSCSI connections to the volume
        /// you are deleting. You should also make sure there is no snapshot in progress. You
        /// can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on the
        /// volume you are deleting and check the snapshot status. For more information, go to
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAvailabilityMonitorTest

        internal virtual DescribeAvailabilityMonitorTestResponse DescribeAvailabilityMonitorTest(DescribeAvailabilityMonitorTestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityMonitorTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityMonitorTestResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityMonitorTestResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the most recent high availability monitoring test that was
        /// performed on the host in a cluster. If a test isn't performed, the status and start
        /// time in the response would be null.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityMonitorTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeAvailabilityMonitorTest">REST API Reference for DescribeAvailabilityMonitorTest Operation</seealso>
        public virtual Task<DescribeAvailabilityMonitorTestResponse> DescribeAvailabilityMonitorTestAsync(DescribeAvailabilityMonitorTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityMonitorTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityMonitorTestResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityMonitorTestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBandwidthRateLimit

        internal virtual DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DescribeBandwidthRateLimitResponse>(request, options);
        }



        /// <summary>
        /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
        /// which means no bandwidth rate limiting is in effect. This operation is supported only
        /// for the stored volume, cached volume, and tape gateway types. To describe bandwidth
        /// rate limits for S3 file gateways, use <a>DescribeBandwidthRateLimitSchedule</a>.
        /// 
        ///  
        /// <para>
        /// This operation returns a value for a bandwidth rate limit only if the limit is set.
        /// If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimit">REST API Reference for DescribeBandwidthRateLimit Operation</seealso>
        public virtual Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBandwidthRateLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBandwidthRateLimitSchedule

        internal virtual DescribeBandwidthRateLimitScheduleResponse DescribeBandwidthRateLimitSchedule(DescribeBandwidthRateLimitScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeBandwidthRateLimitScheduleResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the bandwidth rate limit schedule of a gateway. By default,
        /// gateways do not have bandwidth rate limit schedules, which means no bandwidth rate
        /// limiting is in effect. This operation is supported only for volume, tape and S3 file
        /// gateways. FSx file gateways do not support bandwidth rate limits.
        /// 
        ///  
        /// <para>
        /// This operation returns information about a gateway's bandwidth rate limit schedule.
        /// A bandwidth rate limit schedule consists of one or more bandwidth rate limit intervals.
        /// A bandwidth rate limit interval defines a period of time on one or more days of the
        /// week, during which bandwidth rate limits are specified for uploading, downloading,
        /// or both. 
        /// </para>
        ///  
        /// <para>
        ///  A bandwidth rate limit interval consists of one or more days of the week, a start
        /// hour and minute, an ending hour and minute, and bandwidth rate limits for uploading
        /// and downloading 
        /// </para>
        ///  
        /// <para>
        ///  If no bandwidth rate limit schedule intervals are set for the gateway, this operation
        /// returns an empty response. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimitSchedule">REST API Reference for DescribeBandwidthRateLimitSchedule Operation</seealso>
        public virtual Task<DescribeBandwidthRateLimitScheduleResponse> DescribeBandwidthRateLimitScheduleAsync(DescribeBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBandwidthRateLimitScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCache

        internal virtual DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the cache of a gateway. This operation is only supported
        /// in the cached volume, tape, and file gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as cache, and it includes the amount
        /// of cache allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCache">REST API Reference for DescribeCache Operation</seealso>
        public virtual Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCachediSCSIVolumes

        internal virtual DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeCachediSCSIVolumesResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of the gateway volumes specified in the request. This operation
        /// is only supported in the cached volume gateway types.
        /// 
        ///  
        /// <para>
        /// The list of gateway volumes in the request must be from one gateway. In the response,
        /// Storage Gateway returns volume information sorted by volume Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCachediSCSIVolumes">REST API Reference for DescribeCachediSCSIVolumes Operation</seealso>
        public virtual Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCachediSCSIVolumesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCacheReport

        internal virtual DescribeCacheReportResponse DescribeCacheReport(DescribeCacheReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheReportResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheReportResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified cache report, including completion status
        /// and generation progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheReport service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCacheReport">REST API Reference for DescribeCacheReport Operation</seealso>
        public virtual Task<DescribeCacheReportResponse> DescribeCacheReportAsync(DescribeCacheReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheReportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeChapCredentials

        internal virtual DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DescribeChapCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// information for a specified iSCSI target, one for each target-initiator pair. This
        /// operation is supported in the volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeChapCredentials">REST API Reference for DescribeChapCredentials Operation</seealso>
        public virtual Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChapCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFileSystemAssociations

        internal virtual DescribeFileSystemAssociationsResponse DescribeFileSystemAssociations(DescribeFileSystemAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeFileSystemAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets the file system association information. This operation is only supported for
        /// FSx File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystemAssociations service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeFileSystemAssociations">REST API Reference for DescribeFileSystemAssociations Operation</seealso>
        public virtual Task<DescribeFileSystemAssociationsResponse> DescribeFileSystemAssociationsAsync(DescribeFileSystemAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFileSystemAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGatewayInformation

        internal virtual DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInformationResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about a gateway such as its name, network interfaces, time zone,
        /// status, and software version. To specify which gateway to describe, use the Amazon
        /// Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeGatewayInformation">REST API Reference for DescribeGatewayInformation Operation</seealso>
        public virtual Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMaintenanceStartTime

        internal virtual DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceStartTimeResponse>(request, options);
        }



        /// <summary>
        /// Returns your gateway's maintenance window schedule information, with values for monthly
        /// or weekly cadence, specific day and time to begin maintenance, and which types of
        /// updates to apply. Time values returned are for the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeMaintenanceStartTime">REST API Reference for DescribeMaintenanceStartTime Operation</seealso>
        public virtual Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceStartTimeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNFSFileShares

        internal virtual DescribeNFSFileSharesResponse DescribeNFSFileShares(DescribeNFSFileSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeNFSFileSharesResponse>(request, options);
        }



        /// <summary>
        /// Gets a description for one or more Network File System (NFS) file shares from an S3
        /// File Gateway. This operation is only supported for S3 File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNFSFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNFSFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeNFSFileShares">REST API Reference for DescribeNFSFileShares Operation</seealso>
        public virtual Task<DescribeNFSFileSharesResponse> DescribeNFSFileSharesAsync(DescribeNFSFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNFSFileSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSMBFileShares

        internal virtual DescribeSMBFileSharesResponse DescribeSMBFileShares(DescribeSMBFileSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSMBFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBFileSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeSMBFileSharesResponse>(request, options);
        }



        /// <summary>
        /// Gets a description for one or more Server Message Block (SMB) file shares from a S3
        /// File Gateway. This operation is only supported for S3 File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSMBFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBFileShares">REST API Reference for DescribeSMBFileShares Operation</seealso>
        public virtual Task<DescribeSMBFileSharesResponse> DescribeSMBFileSharesAsync(DescribeSMBFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSMBFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSMBFileSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSMBSettings

        internal virtual DescribeSMBSettingsResponse DescribeSMBSettings(DescribeSMBSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSMBSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeSMBSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets a description of a Server Message Block (SMB) file share settings from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSMBSettings service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBSettings">REST API Reference for DescribeSMBSettings Operation</seealso>
        public virtual Task<DescribeSMBSettingsResponse> DescribeSMBSettingsAsync(DescribeSMBSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSMBSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSMBSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSnapshotSchedule

        internal virtual DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Describes the snapshot schedule for the specified gateway volume. The snapshot schedule
        /// information includes intervals at which snapshots are automatically initiated on the
        /// volume. This operation is only supported in the cached volume and stored volume types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSnapshotSchedule">REST API Reference for DescribeSnapshotSchedule Operation</seealso>
        public virtual Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStorediSCSIVolumes

        internal virtual DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStorediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorediSCSIVolumesResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of the gateway volumes specified in the request. The list
        /// of gateway volumes in the request must be from one gateway. In the response, Storage
        /// Gateway returns volume information sorted by volume ARNs. This operation is only supported
        /// in stored volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeStorediSCSIVolumes">REST API Reference for DescribeStorediSCSIVolumes Operation</seealso>
        public virtual Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStorediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorediSCSIVolumesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTapeArchives

        internal virtual DescribeTapeArchivesResponse DescribeTapeArchives()
        {
            return DescribeTapeArchives(new DescribeTapeArchivesRequest());
        }
        internal virtual DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapeArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeArchivesResponse>(request, options);
        }


        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <c>TapeARN</c> is not specified, Storage Gateway returns a description
        /// of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        public virtual Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTapeArchivesAsync(new DescribeTapeArchivesRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <c>TapeARN</c> is not specified, Storage Gateway returns a description
        /// of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        public virtual Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(DescribeTapeArchivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapeArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeArchivesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTapeRecoveryPoints

        internal virtual DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeRecoveryPointsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of virtual tape recovery points that are available for the specified
        /// tape gateway.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point-in-time view of a virtual tape at which all the data on
        /// the virtual tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway. This operation is only supported in the
        /// tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeRecoveryPoints">REST API Reference for DescribeTapeRecoveryPoints Operation</seealso>
        public virtual Task<DescribeTapeRecoveryPointsResponse> DescribeTapeRecoveryPointsAsync(DescribeTapeRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeRecoveryPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTapes

        internal virtual DescribeTapesResponse DescribeTapes(DescribeTapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapesResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of virtual tapes that correspond to the specified Amazon Resource
        /// Names (ARNs). If <c>TapeARN</c> is not specified, returns a description of the virtual
        /// tapes associated with the specified gateway. This operation is only supported for
        /// the tape gateway type.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <c>Limit</c> field in the body to
        /// limit the number of tapes in the response. If the number of tapes returned in the
        /// response is truncated, the response includes a <c>Marker</c> field. You can use this
        /// <c>Marker</c> value in your subsequent request to retrieve the next set of tapes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapes">REST API Reference for DescribeTapes Operation</seealso>
        public virtual Task<DescribeTapesResponse> DescribeTapesAsync(DescribeTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUploadBuffer

        internal virtual DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return Invoke<DescribeUploadBufferResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the upload buffer of a gateway. This operation is supported
        /// for the stored volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeUploadBuffer">REST API Reference for DescribeUploadBuffer Operation</seealso>
        public virtual Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUploadBufferResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVTLDevices

        internal virtual DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVTLDevicesResponse>(request, options);
        }



        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified tape
        /// gateway. In the response, Storage Gateway returns VTL device information.
        /// 
        ///  
        /// <para>
        /// This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeVTLDevices">REST API Reference for DescribeVTLDevices Operation</seealso>
        public virtual Task<DescribeVTLDevicesResponse> DescribeVTLDevicesAsync(DescribeVTLDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVTLDevicesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorkingStorage

        internal virtual DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkingStorageResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the working storage of a gateway. This operation is only
        /// supported in the stored volumes gateway type. This operation is deprecated in cached
        /// volumes API version (20120630). Use DescribeUploadBuffer instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the DescribeUploadBuffer
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response includes disk IDs that are configured as working storage, and it includes
        /// the amount of working storage allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeWorkingStorage">REST API Reference for DescribeWorkingStorage Operation</seealso>
        public virtual Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkingStorageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetachVolume

        internal virtual DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeResponse>(request, options);
        }



        /// <summary>
        /// Disconnects a volume from an iSCSI connection and then detaches the volume from the
        /// specified gateway. Detaching and attaching a volume enables you to recover your data
        /// from one gateway to a different gateway without creating a snapshot. It also makes
        /// it easier to move your volumes from an on-premises gateway to a gateway hosted on
        /// an Amazon EC2 instance. This operation is only supported in the volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        public virtual Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableGateway

        internal virtual DisableGatewayResponse DisableGateway(DisableGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return Invoke<DisableGatewayResponse>(request, options);
        }



        /// <summary>
        /// Disables a tape gateway when the gateway is no longer functioning. For example, if
        /// your gateway VM is damaged, you can disable the gateway so you can recover virtual
        /// tapes.
        /// 
        ///  
        /// <para>
        /// Use this operation for a tape gateway that is not reachable or not functioning. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        ///  <important> 
        /// <para>
        /// After a gateway is disabled, it cannot be enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DisableGateway">REST API Reference for DisableGateway Operation</seealso>
        public virtual Task<DisableGatewayResponse> DisableGatewayAsync(DisableGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DisableGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateFileSystem

        internal virtual DisassociateFileSystemResponse DisassociateFileSystem(DisassociateFileSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFileSystemResponseUnmarshaller.Instance;

            return Invoke<DisassociateFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an Amazon FSx file system from the specified gateway. After the disassociation
        /// process finishes, the gateway can no longer access the Amazon FSx file system. This
        /// operation is only supported in the FSx File Gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFileSystem service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DisassociateFileSystem">REST API Reference for DisassociateFileSystem Operation</seealso>
        public virtual Task<DisassociateFileSystemResponse> DisassociateFileSystemAsync(DisassociateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFileSystemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EvictFilesFailingUpload

        internal virtual EvictFilesFailingUploadResponse EvictFilesFailingUpload(EvictFilesFailingUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvictFilesFailingUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvictFilesFailingUploadResponseUnmarshaller.Instance;

            return Invoke<EvictFilesFailingUploadResponse>(request, options);
        }



        /// <summary>
        /// Starts a process that cleans the specified file share's cache of file entries that
        /// are failing upload to Amazon S3. This API operation reports success if the request
        /// is received with valid arguments, and there are no other cache clean operations currently
        /// in-progress for the specified file share. After a successful request, the cache clean
        /// operation occurs asynchronously and reports progress using CloudWatch logs and notifications.
        /// 
        ///  <important> 
        /// <para>
        /// If <c>ForceRemove</c> is set to <c>True</c>, the cache clean operation will delete
        /// file data from the gateway which might otherwise be recoverable. We recommend using
        /// this operation only after all other methods to clear files failing upload have been
        /// exhausted, and if your business need outweighs the potential data loss.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvictFilesFailingUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvictFilesFailingUpload service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/EvictFilesFailingUpload">REST API Reference for EvictFilesFailingUpload Operation</seealso>
        public virtual Task<EvictFilesFailingUploadResponse> EvictFilesFailingUploadAsync(EvictFilesFailingUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvictFilesFailingUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvictFilesFailingUploadResponseUnmarshaller.Instance;

            return InvokeAsync<EvictFilesFailingUploadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  JoinDomain

        internal virtual JoinDomainResponse JoinDomain(JoinDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JoinDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinDomainResponseUnmarshaller.Instance;

            return Invoke<JoinDomainResponse>(request, options);
        }



        /// <summary>
        /// Adds a file gateway to an Active Directory domain. This operation is only supported
        /// for file gateways that support the SMB file protocol.
        /// 
        ///  <note> 
        /// <para>
        /// Joining a domain creates an Active Directory computer account in the default organizational
        /// unit, using the gateway's <b>Gateway ID</b> as the account name (for example, SGW-1234ADE).
        /// If your Active Directory environment requires that you pre-stage accounts to facilitate
        /// the join domain process, you will need to create this account ahead of time.
        /// </para>
        ///  
        /// <para>
        /// To create the gateway's computer account in an organizational unit other than the
        /// default, you must specify the organizational unit when joining the domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinDomain service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/JoinDomain">REST API Reference for JoinDomain Operation</seealso>
        public virtual Task<JoinDomainResponse> JoinDomainAsync(JoinDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JoinDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinDomainResponseUnmarshaller.Instance;

            return InvokeAsync<JoinDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAutomaticTapeCreationPolicies

        internal virtual ListAutomaticTapeCreationPoliciesResponse ListAutomaticTapeCreationPolicies(ListAutomaticTapeCreationPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomaticTapeCreationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomaticTapeCreationPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAutomaticTapeCreationPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the automatic tape creation policies for a gateway. If there are no automatic
        /// tape creation policies for the gateway, it returns an empty list.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for tape gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomaticTapeCreationPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomaticTapeCreationPolicies service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListAutomaticTapeCreationPolicies">REST API Reference for ListAutomaticTapeCreationPolicies Operation</seealso>
        public virtual Task<ListAutomaticTapeCreationPoliciesResponse> ListAutomaticTapeCreationPoliciesAsync(ListAutomaticTapeCreationPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomaticTapeCreationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomaticTapeCreationPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutomaticTapeCreationPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCacheReports

        internal virtual ListCacheReportsResponse ListCacheReports(ListCacheReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCacheReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCacheReportsResponseUnmarshaller.Instance;

            return Invoke<ListCacheReportsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of existing cache reports for all file shares associated with your
        /// Amazon Web Services account. This list includes all information provided by the <c>DescribeCacheReport</c>
        /// action, such as report name, status, completion progress, start time, end time, filters,
        /// and tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCacheReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCacheReports service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListCacheReports">REST API Reference for ListCacheReports Operation</seealso>
        public virtual Task<ListCacheReportsResponse> ListCacheReportsAsync(ListCacheReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCacheReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCacheReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCacheReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFileShares

        internal virtual ListFileSharesResponse ListFileShares(ListFileSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return Invoke<ListFileSharesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the file shares for a specific S3 File Gateway, or the list of file
        /// shares that belong to the calling Amazon Web Services account. This operation is only
        /// supported for S3 File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListFileShares">REST API Reference for ListFileShares Operation</seealso>
        public virtual Task<ListFileSharesResponse> ListFileSharesAsync(ListFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFileSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFileSystemAssociations

        internal virtual ListFileSystemAssociationsResponse ListFileSystemAssociations(ListFileSystemAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSystemAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSystemAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListFileSystemAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of <c>FileSystemAssociationSummary</c> objects. Each object contains a
        /// summary of a file system association. This operation is only supported for FSx File
        /// Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileSystemAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileSystemAssociations service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListFileSystemAssociations">REST API Reference for ListFileSystemAssociations Operation</seealso>
        public virtual Task<ListFileSystemAssociationsResponse> ListFileSystemAssociationsAsync(ListFileSystemAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSystemAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSystemAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFileSystemAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGateways

        internal virtual ListGatewaysResponse ListGateways()
        {
            return ListGateways(new ListGatewaysRequest());
        }
        internal virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Lists gateways owned by an Amazon Web Services account in an Amazon Web Services Region
        /// specified in the request. The returned list is ordered by gateway Amazon Resource
        /// Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListGatewaysAsync(new ListGatewaysRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists gateways owned by an Amazon Web Services account in an Amazon Web Services Region
        /// specified in the request. The returned list is ordered by gateway Amazon Resource
        /// Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLocalDisks

        internal virtual ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocalDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return Invoke<ListLocalDisksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the gateway's local disks. To specify which gateway to describe,
        /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
        /// 
        ///  
        /// <para>
        /// The request returns a list of all disks, specifying which are configured as working
        /// storage, cache storage, or stored volume or not configured at all. The response includes
        /// a <c>DiskStatus</c> field. This field can have a value of present (the disk is available
        /// to use), missing (the disk is no longer connected to the gateway), or mismatch (the
        /// disk node is occupied by a disk that has incorrect metadata or the disk content is
        /// corrupted).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListLocalDisks">REST API Reference for ListLocalDisks Operation</seealso>
        public virtual Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocalDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocalDisksResponse>(request, options, cancellationToken);
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
        /// Lists the tags that have been added to the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTapePools

        internal virtual ListTapePoolsResponse ListTapePools(ListTapePoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTapePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapePoolsResponseUnmarshaller.Instance;

            return Invoke<ListTapePoolsResponse>(request, options);
        }



        /// <summary>
        /// Lists custom tape pools. You specify custom tape pools to list by specifying one or
        /// more custom tape pool Amazon Resource Names (ARNs). If you don't specify a custom
        /// tape pool ARN, the operation lists all custom tape pools.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. You can optionally specify the <c>Limit</c> parameter
        /// in the body to limit the number of tape pools in the response. If the number of tape
        /// pools returned in the response is truncated, the response includes a <c>Marker</c>
        /// element that you can use in your subsequent request to retrieve the next set of tape
        /// pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapePools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTapePools service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapePools">REST API Reference for ListTapePools Operation</seealso>
        public virtual Task<ListTapePoolsResponse> ListTapePoolsAsync(ListTapePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTapePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapePoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTapePoolsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTapes

        internal virtual ListTapesResponse ListTapes(ListTapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapesResponseUnmarshaller.Instance;

            return Invoke<ListTapesResponse>(request, options);
        }



        /// <summary>
        /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
        /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
        /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
        /// in both your VTL and VTS.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <c>Limit</c> parameter in the body
        /// to limit the number of tapes in the response. If the number of tapes returned in the
        /// response is truncated, the response includes a <c>Marker</c> element that you can
        /// use in your subsequent request to retrieve the next set of tapes. This operation is
        /// only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapes">REST API Reference for ListTapes Operation</seealso>
        public virtual Task<ListTapesResponse> ListTapesAsync(ListTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTapesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVolumeInitiators

        internal virtual ListVolumeInitiatorsResponse ListVolumeInitiators(ListVolumeInitiatorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeInitiatorsResponse>(request, options);
        }



        /// <summary>
        /// Lists iSCSI initiators that are connected to a volume. You can use this operation
        /// to determine whether a volume is being used or not. This operation is only supported
        /// in the cached volume and stored volume gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumeInitiators service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeInitiators">REST API Reference for ListVolumeInitiators Operation</seealso>
        public virtual Task<ListVolumeInitiatorsResponse> ListVolumeInitiatorsAsync(ListVolumeInitiatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeInitiatorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVolumeRecoveryPoints

        internal virtual ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeRecoveryPointsResponse>(request, options);
        }



        /// <summary>
        /// Lists the recovery points for a specified gateway. This operation is only supported
        /// in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// Each cache volume has one recovery point. A volume recovery point is a point in time
        /// at which all data of the volume is consistent and from which you can create a snapshot
        /// or clone a new cached volume from a source volume. To create a snapshot from a volume
        /// recovery point use the <a>CreateSnapshotFromVolumeRecoveryPoint</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeRecoveryPoints">REST API Reference for ListVolumeRecoveryPoints Operation</seealso>
        public virtual Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeRecoveryPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVolumes

        internal virtual ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return Invoke<ListVolumesResponse>(request, options);
        }



        /// <summary>
        /// Lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The
        /// response includes only the volume ARNs. If you want additional volume information,
        /// use the <a>DescribeStorediSCSIVolumes</a> or the <a>DescribeCachediSCSIVolumes</a>
        /// API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <c>Limit</c> field in the body to
        /// limit the number of volumes in the response. If the number of volumes returned in
        /// the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes. This
        /// operation is only supported in the cached volume and stored volume gateway types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumes">REST API Reference for ListVolumes Operation</seealso>
        public virtual Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NotifyWhenUploaded

        internal virtual NotifyWhenUploadedResponse NotifyWhenUploaded(NotifyWhenUploadedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return Invoke<NotifyWhenUploadedResponse>(request, options);
        }



        /// <summary>
        /// Sends you notification through Amazon EventBridge when all files written to your file
        /// share have been uploaded to Amazon S3.
        /// 
        ///  
        /// <para>
        /// Storage Gateway can send a notification through Amazon EventBridge when all files
        /// written to your file share up to that point in time have been uploaded to Amazon S3.
        /// These files include files written to the file share up to the time that you make a
        /// request for notification. When the upload is done, Storage Gateway sends you notification
        /// through EventBridge. You can configure EventBridge to send the notification through
        /// event targets such as Amazon SNS or Lambda function. This operation is only supported
        /// for S3 File Gateways.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
        /// file upload notification</a> in the <i>Amazon S3 File Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWhenUploaded service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NotifyWhenUploaded service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/NotifyWhenUploaded">REST API Reference for NotifyWhenUploaded Operation</seealso>
        public virtual Task<NotifyWhenUploadedResponse> NotifyWhenUploadedAsync(NotifyWhenUploadedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyWhenUploadedResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RefreshCache

        internal virtual RefreshCacheResponse RefreshCache(RefreshCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RefreshCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return Invoke<RefreshCacheResponse>(request, options);
        }



        /// <summary>
        /// Refreshes the cached inventory of objects for the specified file share. This operation
        /// finds objects in the Amazon S3 bucket that were added, removed, or replaced since
        /// the gateway last listed the bucket's contents and cached the results. This operation
        /// does not import files into the S3 File Gateway cache storage. It only updates the
        /// cached inventory to reflect changes in the inventory of the objects in the S3 bucket.
        /// This operation is only supported in the S3 File Gateway types.
        /// 
        ///  
        /// <para>
        /// You can subscribe to be notified through an Amazon CloudWatch event when your <c>RefreshCache</c>
        /// operation completes. For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
        /// This operation is Only supported for S3 File Gateways.
        /// </para>
        ///  
        /// <para>
        /// When this API is called, it only initiates the refresh operation. When the API call
        /// completes and returns a success code, it doesn't necessarily mean that the file refresh
        /// has completed. You should use the refresh-complete notification to determine that
        /// the operation has completed before you check for new files on the gateway file share.
        /// You can subscribe to be notified through a CloudWatch event when your <c>RefreshCache</c>
        /// operation completes.
        /// </para>
        ///  
        /// <para>
        /// Throttle limit: This API is asynchronous, so the gateway will accept no more than
        /// two refreshes at any time. We recommend using the refresh-complete CloudWatch event
        /// notification before issuing additional requests. For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// Wait at least 60 seconds between consecutive RefreshCache API requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you invoke the RefreshCache API when two requests are already being processed,
        /// any new request will cause an <c>InvalidGatewayRequestException</c> error because
        /// too many requests were sent to the server.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// The S3 bucket name does not need to be included when entering the list of folders
        /// in the FolderList parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RefreshCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RefreshCache">REST API Reference for RefreshCache Operation</seealso>
        public virtual Task<RefreshCacheResponse> RefreshCacheAsync(RefreshCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RefreshCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetCache

        internal virtual ResetCacheResponse ResetCache(ResetCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return Invoke<ResetCacheResponse>(request, options);
        }


        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="gatewayARN">A property of ResetCacheRequest used to execute the ResetCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        public virtual Task<ResetCacheResponse> ResetCacheAsync(string gatewayARN, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ResetCacheRequest();
            request.GatewayARN = gatewayARN;
            return ResetCacheAsync(request, cancellationToken);
        }



        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        public virtual Task<ResetCacheResponse> ResetCacheAsync(ResetCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ResetCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RetrieveTapeArchive

        internal virtual RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeArchiveResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a tape gateway.
        /// Virtual tapes archived in the VTS are not associated with any gateway. However after
        /// a tape is retrieved, it is associated with a gateway, even though it is also listed
        /// in the VTS, that is, archive. This operation is only supported in the tape gateway
        /// type.
        /// 
        ///  
        /// <para>
        /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
        /// another gateway. You must archive the tape again before you can retrieve it to another
        /// gateway. This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeArchive">REST API Reference for RetrieveTapeArchive Operation</seealso>
        public virtual Task<RetrieveTapeArchiveResponse> RetrieveTapeArchiveAsync(RetrieveTapeArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RetrieveTapeRecoveryPoint

        internal virtual RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the recovery point for the specified virtual tape. This operation is only
        /// supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        ///  <note> 
        /// <para>
        /// The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only.
        /// The virtual tape can be retrieved to only a tape gateway. There is no charge for retrieving
        /// recovery points.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeRecoveryPoint">REST API Reference for RetrieveTapeRecoveryPoint Operation</seealso>
        public virtual Task<RetrieveTapeRecoveryPointResponse> RetrieveTapeRecoveryPointAsync(RetrieveTapeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeRecoveryPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetLocalConsolePassword

        internal virtual SetLocalConsolePasswordResponse SetLocalConsolePassword(SetLocalConsolePasswordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return Invoke<SetLocalConsolePasswordResponse>(request, options);
        }



        /// <summary>
        /// Sets the password for your VM local console. When you log in to the local console
        /// for the first time, you log in to the VM with the default credentials. We recommend
        /// that you set a new password. You don't need to know the default password to set a
        /// new password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetLocalConsolePassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetLocalConsolePassword">REST API Reference for SetLocalConsolePassword Operation</seealso>
        public virtual Task<SetLocalConsolePasswordResponse> SetLocalConsolePasswordAsync(SetLocalConsolePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<SetLocalConsolePasswordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetSMBGuestPassword

        internal virtual SetSMBGuestPasswordResponse SetSMBGuestPassword(SetSMBGuestPasswordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetSMBGuestPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMBGuestPasswordResponseUnmarshaller.Instance;

            return Invoke<SetSMBGuestPasswordResponse>(request, options);
        }



        /// <summary>
        /// Sets the password for the guest user <c>smbguest</c>. The <c>smbguest</c> user is
        /// the user when the authentication method for the file share is set to <c>GuestAccess</c>.
        /// This operation only supported for S3 File Gateways
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSMBGuestPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSMBGuestPassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetSMBGuestPassword">REST API Reference for SetSMBGuestPassword Operation</seealso>
        public virtual Task<SetSMBGuestPasswordResponse> SetSMBGuestPasswordAsync(SetSMBGuestPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetSMBGuestPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMBGuestPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<SetSMBGuestPasswordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ShutdownGateway

        internal virtual ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShutdownGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return Invoke<ShutdownGatewayResponse>(request, options);
        }



        /// <summary>
        /// Shuts down a Tape Gateway or Volume Gateway. To specify which gateway to shut down,
        /// use the Amazon Resource Name (ARN) of the gateway in the body of your request.
        /// 
        ///  <note> 
        /// <para>
        /// This API action cannot be used to shut down S3 File Gateway or FSx File Gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation shuts down the gateway service component running in the gateway's virtual
        /// machine (VM) and not the host VM.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.
        /// </para>
        ///  </note> 
        /// <para>
        /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
        /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
        /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
        /// storage volumes, and there are no snapshots taken.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you make a shutdown request, you will get a <c>200 OK</c> success response immediately.
        /// However, it might take some time for the gateway to shut down. You can call the <a>DescribeGatewayInformation</a>
        /// API to check the status. For more information, see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ShutdownGateway">REST API Reference for ShutdownGateway Operation</seealso>
        public virtual Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShutdownGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ShutdownGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAvailabilityMonitorTest

        internal virtual StartAvailabilityMonitorTestResponse StartAvailabilityMonitorTest(StartAvailabilityMonitorTestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAvailabilityMonitorTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAvailabilityMonitorTestResponseUnmarshaller.Instance;

            return Invoke<StartAvailabilityMonitorTestResponse>(request, options);
        }



        /// <summary>
        /// Start a test that verifies that the specified gateway is configured for High Availability
        /// monitoring in your host environment. This request only initiates the test and that
        /// a successful response only indicates that the test was started. It doesn't indicate
        /// that the test passed. For the status of the test, invoke the <c>DescribeAvailabilityMonitorTest</c>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Starting this test will cause your gateway to go offline for a brief period.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAvailabilityMonitorTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartAvailabilityMonitorTest">REST API Reference for StartAvailabilityMonitorTest Operation</seealso>
        public virtual Task<StartAvailabilityMonitorTestResponse> StartAvailabilityMonitorTestAsync(StartAvailabilityMonitorTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAvailabilityMonitorTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAvailabilityMonitorTestResponseUnmarshaller.Instance;

            return InvokeAsync<StartAvailabilityMonitorTestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCacheReport

        internal virtual StartCacheReportResponse StartCacheReport(StartCacheReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCacheReportResponseUnmarshaller.Instance;

            return Invoke<StartCacheReportResponse>(request, options);
        }



        /// <summary>
        /// Starts generating a report of the file metadata currently cached by an S3 File Gateway
        /// for a specific file share. You can use this report to identify and resolve issues
        /// if you have files failing upload from your gateway to Amazon S3. The report is a CSV
        /// file containing a list of files which match the set of filter parameters you specify
        /// in the request.
        /// 
        ///  <note> 
        /// <para>
        /// The <b>Files Failing Upload</b> flag is reset every 24 hours and during gateway reboot.
        /// If this report captures the files after the reset, but before they become flagged
        /// again, they will not be reported as <b>Files Failing Upload</b>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following requirements must be met to successfully generate a cache report:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have <c>s3:PutObject</c> and <c>s3:AbortMultipartUpload</c> permissions for
        /// the Amazon S3 bucket where you want to store the cache report.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No other cache reports can currently be in-progress for the specified file share.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There must be fewer than 10 existing cache reports for the specified file share.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The gateway must be online and connected to Amazon Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The root disk must have at least 20GB of free space when report generation starts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify at least one value for <c>InclusionFilters</c> or <c>ExclusionFilters</c>
        /// in the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCacheReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCacheReport service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartCacheReport">REST API Reference for StartCacheReport Operation</seealso>
        public virtual Task<StartCacheReportResponse> StartCacheReportAsync(StartCacheReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCacheReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCacheReportResponseUnmarshaller.Instance;

            return InvokeAsync<StartCacheReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartGateway

        internal virtual StartGatewayResponse StartGateway(StartGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return Invoke<StartGatewayResponse>(request, options);
        }



        /// <summary>
        /// Starts a gateway that you previously shut down (see <a>ShutdownGateway</a>). After
        /// the gateway starts, you can then make other API calls, your applications can read
        /// from or write to the gateway's storage volumes and you will be able to take snapshot
        /// backups.
        /// 
        ///  <note> 
        /// <para>
        /// When you make a request, you will get a 200 OK success response immediately. However,
        /// it might take some time for the gateway to be ready. You should call <a>DescribeGatewayInformation</a>
        /// and check the status before making any additional API calls. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartGateway">REST API Reference for StartGateway Operation</seealso>
        public virtual Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<StartGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAutomaticTapeCreationPolicy

        internal virtual UpdateAutomaticTapeCreationPolicyResponse UpdateAutomaticTapeCreationPolicy(UpdateAutomaticTapeCreationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomaticTapeCreationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomaticTapeCreationPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomaticTapeCreationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the automatic tape creation policy of a gateway. Use this to update the policy
        /// with a new set of automatic tape creation rules. This is only supported for tape gateways.
        /// 
        ///  
        /// <para>
        /// By default, there is no automatic tape creation policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// A gateway can have only one automatic tape creation policy.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomaticTapeCreationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateAutomaticTapeCreationPolicy">REST API Reference for UpdateAutomaticTapeCreationPolicy Operation</seealso>
        public virtual Task<UpdateAutomaticTapeCreationPolicyResponse> UpdateAutomaticTapeCreationPolicyAsync(UpdateAutomaticTapeCreationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomaticTapeCreationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomaticTapeCreationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutomaticTapeCreationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBandwidthRateLimit

        internal virtual UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateBandwidthRateLimitResponse>(request, options);
        }



        /// <summary>
        /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
        /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
        /// rate limit, the existing rate limit remains. This operation is supported only for
        /// the stored volume, cached volume, and tape gateway types. To update bandwidth rate
        /// limits for S3 file gateways, use <a>UpdateBandwidthRateLimitSchedule</a>.
        /// 
        ///  
        /// <para>
        /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
        /// the gateway does not have any limitations on its bandwidth usage and could potentially
        /// use the maximum available bandwidth.
        /// </para>
        ///  
        /// <para>
        /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimit">REST API Reference for UpdateBandwidthRateLimit Operation</seealso>
        public virtual Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBandwidthRateLimitResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBandwidthRateLimitSchedule

        internal virtual UpdateBandwidthRateLimitScheduleResponse UpdateBandwidthRateLimitSchedule(UpdateBandwidthRateLimitScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateBandwidthRateLimitScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to initiate or update a gateway's bandwidth rate limit schedule.
        /// This operation is supported for volume, tape, and S3 file gateways. S3 file gateways
        /// support bandwidth rate limits for upload only. FSx file gateways do not support bandwidth
        /// rate limits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimitSchedule">REST API Reference for UpdateBandwidthRateLimitSchedule Operation</seealso>
        public virtual Task<UpdateBandwidthRateLimitScheduleResponse> UpdateBandwidthRateLimitScheduleAsync(UpdateBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBandwidthRateLimitScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateChapCredentials

        internal virtual UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<UpdateChapCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
        /// security, you might use it. This operation is supported in the volume and tape gateway
        /// types.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateChapCredentials">REST API Reference for UpdateChapCredentials Operation</seealso>
        public virtual Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChapCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFileSystemAssociation

        internal virtual UpdateFileSystemAssociationResponse UpdateFileSystemAssociation(UpdateFileSystemAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateFileSystemAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates a file system association. This operation is only supported in the FSx File
        /// Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystemAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFileSystemAssociation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateFileSystemAssociation">REST API Reference for UpdateFileSystemAssociation Operation</seealso>
        public virtual Task<UpdateFileSystemAssociationResponse> UpdateFileSystemAssociationAsync(UpdateFileSystemAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFileSystemAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGatewayInformation

        internal virtual UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInformationResponse>(request, options);
        }



        /// <summary>
        /// Updates a gateway's metadata, which includes the gateway's name, time zone, and metadata
        /// cache size. To specify which gateway to update, use the Amazon Resource Name (ARN)
        /// of the gateway in your request.
        /// 
        ///  <note> 
        /// <para>
        /// For gateways activated after September 2, 2015, the gateway's ARN contains the gateway
        /// ID rather than the gateway name. However, changing the name of the gateway has no
        /// effect on the gateway's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        public virtual Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayInformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGatewaySoftwareNow

        internal virtual UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewaySoftwareNowResponse>(request, options);
        }



        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <c>200 OK</c> success response immediately.
        /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
        /// to verify the gateway is in the <c>STATE_RUNNING</c> state.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A software update forces a system restart of your gateway. You can minimize the chance
        /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
        /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// your Windows iSCSI settings</a> and <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// your Linux iSCSI settings</a>, respectively.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        public virtual Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewaySoftwareNowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMaintenanceStartTime

        internal virtual UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceStartTimeResponse>(request, options);
        }



        /// <summary>
        /// Updates a gateway's maintenance window schedule, with settings for monthly or weekly
        /// cadence, specific day and time to begin maintenance, and which types of updates to
        /// apply. Time configuration uses the gateway's time zone. You can pass values for a
        /// complete maintenance schedule, or update policy, or both. Previous values will persist
        /// for whichever setting you choose not to modify. If an incomplete or invalid maintenance
        /// schedule is passed, the entire request will be rejected with an error and no changes
        /// will occur.
        /// 
        ///  
        /// <para>
        /// A complete maintenance schedule must include values for <i>both</i> <c>MinuteOfHour</c>
        /// and <c>HourOfDay</c>, and <i>either</i> <c>DayOfMonth</c> <i>or</i> <c>DayOfWeek</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend keeping maintenance updates turned on, except in specific use cases where
        /// the brief disruptions caused by updating the gateway could critically impact your
        /// deployment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateMaintenanceStartTime">REST API Reference for UpdateMaintenanceStartTime Operation</seealso>
        public virtual Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceStartTimeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateNFSFileShare

        internal virtual UpdateNFSFileShareResponse UpdateNFSFileShare(UpdateNFSFileShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<UpdateNFSFileShareResponse>(request, options);
        }



        /// <summary>
        /// Updates a Network File System (NFS) file share. This operation is only supported in
        /// S3 File Gateways.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the following file share settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default storage class for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Metadata defaults for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed NFS clients for your file share
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Squash settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write status of your file share
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNFSFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateNFSFileShare">REST API Reference for UpdateNFSFileShare Operation</seealso>
        public virtual Task<UpdateNFSFileShareResponse> UpdateNFSFileShareAsync(UpdateNFSFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNFSFileShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSMBFileShare

        internal virtual UpdateSMBFileShareResponse UpdateSMBFileShare(UpdateSMBFileShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareResponseUnmarshaller.Instance;

            return Invoke<UpdateSMBFileShareResponse>(request, options);
        }



        /// <summary>
        /// Updates a Server Message Block (SMB) file share. This operation is only supported
        /// for S3 File Gateways.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// File gateways require Security Token Service (Amazon Web Services STS) to be activated
        /// to enable you to create a file share. Make sure that Amazon Web Services STS is activated
        /// in the Amazon Web Services Region you are creating your file gateway in. If Amazon
        /// Web Services STS is not activated in this Amazon Web Services Region, activate it.
        /// For information about how to activate Amazon Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Identity and Access Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShare">REST API Reference for UpdateSMBFileShare Operation</seealso>
        public virtual Task<UpdateSMBFileShareResponse> UpdateSMBFileShareAsync(UpdateSMBFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSMBFileShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSMBFileShareVisibility

        internal virtual UpdateSMBFileShareVisibilityResponse UpdateSMBFileShareVisibility(UpdateSMBFileShareVisibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareVisibilityResponseUnmarshaller.Instance;

            return Invoke<UpdateSMBFileShareVisibilityResponse>(request, options);
        }



        /// <summary>
        /// Controls whether the shares on an S3 File Gateway are visible in a net view or browse
        /// list. The operation is only supported for S3 File Gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShareVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBFileShareVisibility service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShareVisibility">REST API Reference for UpdateSMBFileShareVisibility Operation</seealso>
        public virtual Task<UpdateSMBFileShareVisibilityResponse> UpdateSMBFileShareVisibilityAsync(UpdateSMBFileShareVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareVisibilityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSMBFileShareVisibilityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSMBLocalGroups

        internal virtual UpdateSMBLocalGroupsResponse UpdateSMBLocalGroups(UpdateSMBLocalGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBLocalGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBLocalGroupsResponseUnmarshaller.Instance;

            return Invoke<UpdateSMBLocalGroupsResponse>(request, options);
        }



        /// <summary>
        /// Updates the list of Active Directory users and groups that have special permissions
        /// for SMB file shares on the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBLocalGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBLocalGroups service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBLocalGroups">REST API Reference for UpdateSMBLocalGroups Operation</seealso>
        public virtual Task<UpdateSMBLocalGroupsResponse> UpdateSMBLocalGroupsAsync(UpdateSMBLocalGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBLocalGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBLocalGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSMBLocalGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSMBSecurityStrategy

        internal virtual UpdateSMBSecurityStrategyResponse UpdateSMBSecurityStrategy(UpdateSMBSecurityStrategyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBSecurityStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBSecurityStrategyResponseUnmarshaller.Instance;

            return Invoke<UpdateSMBSecurityStrategyResponse>(request, options);
        }



        /// <summary>
        /// Updates the SMB security strategy level for an Amazon S3 file gateway. This action
        /// is only supported for Amazon S3 file gateways.
        /// 
        ///  <note> 
        /// <para>
        /// For information about configuring this setting using the Amazon Web Services console,
        /// see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/security-strategy.html">Setting
        /// a security level for your gateway</a> in the <i>Amazon S3 File Gateway User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A higher security strategy level can affect performance of the gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBSecurityStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBSecurityStrategy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBSecurityStrategy">REST API Reference for UpdateSMBSecurityStrategy Operation</seealso>
        public virtual Task<UpdateSMBSecurityStrategyResponse> UpdateSMBSecurityStrategyAsync(UpdateSMBSecurityStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSMBSecurityStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBSecurityStrategyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSMBSecurityStrategyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSnapshotSchedule

        internal virtual UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates a snapshot schedule configured for a gateway volume. This operation is only
        /// supported in the cached volume and stored volume gateway types.
        /// 
        ///  
        /// <para>
        /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
        /// time of the volume. You can use this API to change the snapshot schedule configured
        /// for the volume.
        /// </para>
        ///  
        /// <para>
        /// In the request you must identify the gateway volume whose snapshot schedule you want
        /// to update, and the schedule information, including when you want the snapshot to begin
        /// on a day and the frequency (in hours) of snapshots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSnapshotSchedule">REST API Reference for UpdateSnapshotSchedule Operation</seealso>
        public virtual Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateVTLDeviceType

        internal virtual UpdateVTLDeviceTypeResponse UpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateVTLDeviceTypeResponse>(request, options);
        }



        /// <summary>
        /// Updates the type of medium changer in a tape gateway. When you activate a tape gateway,
        /// you select a medium changer type for the tape gateway. This operation enables you
        /// to select a different type of medium changer after a tape gateway is activated. This
        /// operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVTLDeviceType service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateVTLDeviceType">REST API Reference for UpdateVTLDeviceType Operation</seealso>
        public virtual Task<UpdateVTLDeviceTypeResponse> UpdateVTLDeviceTypeAsync(UpdateVTLDeviceTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVTLDeviceTypeResponse>(request, options, cancellationToken);
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