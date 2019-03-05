/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Implementation for accessing StorageGateway
    ///
    /// AWS Storage Gateway Service 
    /// <para>
    /// AWS Storage Gateway is the service that connects an on-premises software appliance
    /// with cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and AWS's storage infrastructure. The service enables you
    /// to securely upload data to the AWS cloud for cost effective backup and rapid disaster
    /// recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>AWS Storage Gateway Service API
    /// Reference</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewayHTTPRequestsHeaders">AWS
    /// Storage Gateway Required Request Headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewaySigningRequests">Signing
    /// Requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#APIErrorResponses">Error
    /// Responses</a>: Provides reference information about AWS Storage Gateway errors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_Operations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sg_region">AWS Storage
    /// Gateway Regions and Endpoints:</a> Provides a list of each AWS region and endpoints
    /// available for use with AWS Storage Gateway. 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// AWS Storage Gateway resource IDs are in uppercase. When you use these resource IDs
    /// with the Amazon EC2 API, EC2 expects resource IDs in lowercase. You must change your
    /// resource ID to lowercase to use it with the EC2 API. For example, in Storage Gateway
    /// the ID for a volume might be <code>vol-AA22BB012345DAF670</code>. When you use this
    /// ID with the EC2 API, you must change it to <code>vol-aa22bb012345daf670</code>. Otherwise,
    /// the EC2 API might not behave as expected.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// IDs for Storage Gateway volumes and Amazon EBS snapshots created from gateway volumes
    /// are changing to a longer format. Starting in December 2016, all new volumes and snapshots
    /// will be created with a 17-character string. Starting in April 2016, you will be able
    /// to use these longer IDs so you can test your systems with the new format. For more
    /// information, see <a href="https://aws.amazon.com/ec2/faqs/#longer-ids">Longer EC2
    /// and EBS Resource IDs</a>. 
    /// </para>
    ///  
    /// <para>
    ///  For example, a volume Amazon Resource Name (ARN) with the longer volume ID format
    /// looks like the following:
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:storagegateway:us-west-2:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABBCCDDEEFFG</code>.
    /// </para>
    ///  
    /// <para>
    /// A snapshot ID with the longer ID format looks like the following: <code>snap-78e226633445566ee</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://forums.aws.amazon.com/ann.jspa?annID=3557">Announcement:
    /// Heads-up – Longer AWS Storage Gateway volume and snapshot IDs coming in 2016</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AmazonStorageGatewayClient : AmazonServiceClient, IAmazonStorageGateway
    {
        private static IServiceMetadata serviceMetadata = new AmazonStorageGatewayMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStorageGatewayConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return Invoke<ActivateGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ActivateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ActivateGateway">REST API Reference for ActivateGateway Operation</seealso>
        public virtual Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddCache

        internal virtual AddCacheResponse AddCache(AddCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCacheResponseUnmarshaller.Instance;

            return Invoke<AddCacheResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddCache">REST API Reference for AddCache Operation</seealso>
        public virtual Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCacheResponseUnmarshaller.Instance;

            return InvokeAsync<AddCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddUploadBuffer

        internal virtual AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return Invoke<AddUploadBufferResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddUploadBuffer">REST API Reference for AddUploadBuffer Operation</seealso>
        public virtual Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<AddUploadBufferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddWorkingStorage

        internal virtual AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<AddWorkingStorageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddWorkingStorage">REST API Reference for AddWorkingStorage Operation</seealso>
        public virtual Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<AddWorkingStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        internal virtual AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public virtual Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelArchival

        internal virtual CancelArchivalResponse CancelArchival(CancelArchivalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelArchivalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return Invoke<CancelArchivalResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelArchival operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelArchival">REST API Reference for CancelArchival Operation</seealso>
        public virtual Task<CancelArchivalResponse> CancelArchivalAsync(CancelArchivalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelArchivalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelArchivalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelRetrieval

        internal virtual CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return Invoke<CancelRetrievalResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelRetrieval operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelRetrieval">REST API Reference for CancelRetrieval Operation</seealso>
        public virtual Task<CancelRetrievalResponse> CancelRetrievalAsync(CancelRetrievalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelRetrievalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCachediSCSIVolume

        internal virtual CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateCachediSCSIVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCachediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateCachediSCSIVolume">REST API Reference for CreateCachediSCSIVolume Operation</seealso>
        public virtual Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCachediSCSIVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNFSFileShare

        internal virtual CreateNFSFileShareResponse CreateNFSFileShare(CreateNFSFileShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<CreateNFSFileShareResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNFSFileShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNFSFileShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateNFSFileShare">REST API Reference for CreateNFSFileShare Operation</seealso>
        public virtual Task<CreateNFSFileShareResponse> CreateNFSFileShareAsync(CreateNFSFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNFSFileShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSMBFileShare

        internal virtual CreateSMBFileShareResponse CreateSMBFileShare(CreateSMBFileShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMBFileShareResponseUnmarshaller.Instance;

            return Invoke<CreateSMBFileShareResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSMBFileShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSMBFileShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSMBFileShare">REST API Reference for CreateSMBFileShare Operation</seealso>
        public virtual Task<CreateSMBFileShareResponse> CreateSMBFileShareAsync(CreateSMBFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMBFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSMBFileShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint

        internal virtual CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotFromVolumeRecoveryPointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotFromVolumeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshotFromVolumeRecoveryPoint">REST API Reference for CreateSnapshotFromVolumeRecoveryPoint Operation</seealso>
        public virtual Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotFromVolumeRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorediSCSIVolume

        internal virtual CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateStorediSCSIVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorediSCSIVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateStorediSCSIVolume">REST API Reference for CreateStorediSCSIVolume Operation</seealso>
        public virtual Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorediSCSIVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTapes

        internal virtual CreateTapesResponse CreateTapes(CreateTapesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return Invoke<CreateTapesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapes">REST API Reference for CreateTapes Operation</seealso>
        public virtual Task<CreateTapesResponse> CreateTapesAsync(CreateTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTapeWithBarcode

        internal virtual CreateTapeWithBarcodeResponse CreateTapeWithBarcode(CreateTapeWithBarcodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return Invoke<CreateTapeWithBarcodeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTapeWithBarcode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapeWithBarcode">REST API Reference for CreateTapeWithBarcode Operation</seealso>
        public virtual Task<CreateTapeWithBarcodeResponse> CreateTapeWithBarcodeAsync(CreateTapeWithBarcodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapeWithBarcodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBandwidthRateLimit

        internal virtual DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteBandwidthRateLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteBandwidthRateLimit">REST API Reference for DeleteBandwidthRateLimit Operation</seealso>
        public virtual Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBandwidthRateLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChapCredentials

        internal virtual DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteChapCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteChapCredentials">REST API Reference for DeleteChapCredentials Operation</seealso>
        public virtual Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChapCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileShare

        internal virtual DeleteFileShareResponse DeleteFileShare(DeleteFileShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return Invoke<DeleteFileShareResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFileShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteFileShare">REST API Reference for DeleteFileShare Operation</seealso>
        public virtual Task<DeleteFileShareResponse> DeleteFileShareAsync(DeleteFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGateway

        internal virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotSchedule

        internal virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTape

        internal virtual DeleteTapeResponse DeleteTape(DeleteTapeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTapeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTape operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTape">REST API Reference for DeleteTape Operation</seealso>
        public virtual Task<DeleteTapeResponse> DeleteTapeAsync(DeleteTapeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTapeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTapeArchive

        internal virtual DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeArchiveResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapeArchive">REST API Reference for DeleteTapeArchive Operation</seealso>
        public virtual Task<DeleteTapeArchiveResponse> DeleteTapeArchiveAsync(DeleteTapeArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBandwidthRateLimit

        internal virtual DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DescribeBandwidthRateLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimit">REST API Reference for DescribeBandwidthRateLimit Operation</seealso>
        public virtual Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBandwidthRateLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCache

        internal virtual DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCache">REST API Reference for DescribeCache Operation</seealso>
        public virtual Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCachediSCSIVolumes

        internal virtual DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeCachediSCSIVolumesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCachediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCachediSCSIVolumes">REST API Reference for DescribeCachediSCSIVolumes Operation</seealso>
        public virtual Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCachediSCSIVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChapCredentials

        internal virtual DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DescribeChapCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeChapCredentials">REST API Reference for DescribeChapCredentials Operation</seealso>
        public virtual Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChapCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGatewayInformation

        internal virtual DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInformationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeGatewayInformation">REST API Reference for DescribeGatewayInformation Operation</seealso>
        public virtual Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceStartTime

        internal virtual DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceStartTimeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeMaintenanceStartTime">REST API Reference for DescribeMaintenanceStartTime Operation</seealso>
        public virtual Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceStartTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNFSFileShares

        internal virtual DescribeNFSFileSharesResponse DescribeNFSFileShares(DescribeNFSFileSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeNFSFileSharesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNFSFileShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNFSFileShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeNFSFileShares">REST API Reference for DescribeNFSFileShares Operation</seealso>
        public virtual Task<DescribeNFSFileSharesResponse> DescribeNFSFileSharesAsync(DescribeNFSFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNFSFileSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSMBFileShares

        internal virtual DescribeSMBFileSharesResponse DescribeSMBFileShares(DescribeSMBFileSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSMBFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBFileSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeSMBFileSharesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSMBFileShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBFileShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBFileShares">REST API Reference for DescribeSMBFileShares Operation</seealso>
        public virtual Task<DescribeSMBFileSharesResponse> DescribeSMBFileSharesAsync(DescribeSMBFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSMBFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSMBFileSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSMBSettings

        internal virtual DescribeSMBSettingsResponse DescribeSMBSettings(DescribeSMBSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSMBSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeSMBSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSMBSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBSettings">REST API Reference for DescribeSMBSettings Operation</seealso>
        public virtual Task<DescribeSMBSettingsResponse> DescribeSMBSettingsAsync(DescribeSMBSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSMBSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSMBSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSMBSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotSchedule

        internal virtual DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSnapshotSchedule">REST API Reference for DescribeSnapshotSchedule Operation</seealso>
        public virtual Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorediSCSIVolumes

        internal virtual DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorediSCSIVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorediSCSIVolumesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorediSCSIVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeStorediSCSIVolumes">REST API Reference for DescribeStorediSCSIVolumes Operation</seealso>
        public virtual Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
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
        /// Initiates the asynchronous execution of the DescribeTapeArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        public virtual Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(DescribeTapeArchivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTapeArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeArchivesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTapeRecoveryPoints

        internal virtual DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeRecoveryPointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeRecoveryPoints">REST API Reference for DescribeTapeRecoveryPoints Operation</seealso>
        public virtual Task<DescribeTapeRecoveryPointsResponse> DescribeTapeRecoveryPointsAsync(DescribeTapeRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeRecoveryPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTapes

        internal virtual DescribeTapesResponse DescribeTapes(DescribeTapesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapes">REST API Reference for DescribeTapes Operation</seealso>
        public virtual Task<DescribeTapesResponse> DescribeTapesAsync(DescribeTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUploadBuffer

        internal virtual DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return Invoke<DescribeUploadBufferResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUploadBuffer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeUploadBuffer">REST API Reference for DescribeUploadBuffer Operation</seealso>
        public virtual Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUploadBufferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUploadBufferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVTLDevices

        internal virtual DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVTLDevicesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVTLDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeVTLDevices">REST API Reference for DescribeVTLDevices Operation</seealso>
        public virtual Task<DescribeVTLDevicesResponse> DescribeVTLDevicesAsync(DescribeVTLDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVTLDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkingStorage

        internal virtual DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkingStorageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkingStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeWorkingStorage">REST API Reference for DescribeWorkingStorage Operation</seealso>
        public virtual Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkingStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        internal virtual DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        public virtual Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableGateway

        internal virtual DisableGatewayResponse DisableGateway(DisableGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return Invoke<DisableGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DisableGateway">REST API Reference for DisableGateway Operation</seealso>
        public virtual Task<DisableGatewayResponse> DisableGatewayAsync(DisableGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DisableGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JoinDomain

        internal virtual JoinDomainResponse JoinDomain(JoinDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinDomainResponseUnmarshaller.Instance;

            return Invoke<JoinDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the JoinDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JoinDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/JoinDomain">REST API Reference for JoinDomain Operation</seealso>
        public virtual Task<JoinDomainResponse> JoinDomainAsync(JoinDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinDomainResponseUnmarshaller.Instance;

            return InvokeAsync<JoinDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFileShares

        internal virtual ListFileSharesResponse ListFileShares(ListFileSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return Invoke<ListFileSharesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFileShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFileShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListFileShares">REST API Reference for ListFileShares Operation</seealso>
        public virtual Task<ListFileSharesResponse> ListFileSharesAsync(ListFileSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFileSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFileSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGateways

        internal virtual ListGatewaysResponse ListGateways()
        {
            return ListGateways(new ListGatewaysRequest());
        }
        internal virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Lists gateways owned by an AWS account in a region specified in the request. The returned
        /// list is ordered by gateway Amazon Resource Name (ARN).
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
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLocalDisks

        internal virtual ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocalDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return Invoke<ListLocalDisksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLocalDisks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListLocalDisks">REST API Reference for ListLocalDisks Operation</seealso>
        public virtual Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocalDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocalDisksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTapes

        internal virtual ListTapesResponse ListTapes(ListTapesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapesResponseUnmarshaller.Instance;

            return Invoke<ListTapesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTapes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapes">REST API Reference for ListTapes Operation</seealso>
        public virtual Task<ListTapesResponse> ListTapesAsync(ListTapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTapesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTapesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVolumeInitiators

        internal virtual ListVolumeInitiatorsResponse ListVolumeInitiators(ListVolumeInitiatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeInitiatorsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeInitiators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeInitiators">REST API Reference for ListVolumeInitiators Operation</seealso>
        public virtual Task<ListVolumeInitiatorsResponse> ListVolumeInitiatorsAsync(ListVolumeInitiatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeInitiatorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVolumeRecoveryPoints

        internal virtual ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeRecoveryPointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumeRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeRecoveryPoints">REST API Reference for ListVolumeRecoveryPoints Operation</seealso>
        public virtual Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeRecoveryPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVolumes

        internal virtual ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return Invoke<ListVolumesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumes">REST API Reference for ListVolumes Operation</seealso>
        public virtual Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyWhenUploaded

        internal virtual NotifyWhenUploadedResponse NotifyWhenUploaded(NotifyWhenUploadedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return Invoke<NotifyWhenUploadedResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyWhenUploaded operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyWhenUploaded operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/NotifyWhenUploaded">REST API Reference for NotifyWhenUploaded Operation</seealso>
        public virtual Task<NotifyWhenUploadedResponse> NotifyWhenUploadedAsync(NotifyWhenUploadedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyWhenUploadedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RefreshCache

        internal virtual RefreshCacheResponse RefreshCache(RefreshCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return Invoke<RefreshCacheResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RefreshCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RefreshCache">REST API Reference for RefreshCache Operation</seealso>
        public virtual Task<RefreshCacheResponse> RefreshCacheAsync(RefreshCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetCache

        internal virtual ResetCacheResponse ResetCache(ResetCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return Invoke<ResetCacheResponse>(request, options);
        }


        /// <summary>
        /// Resets all cache disks that have encountered a error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters a error, the gateway
        /// prevents read and write operations on virtual tapes in the gateway. For example, an
        /// error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point you can reconfigure the
        /// disks as cache disks. This operation is only supported in the cached volume and tape
        /// types.
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
        /// Initiates the asynchronous execution of the ResetCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        public virtual Task<ResetCacheResponse> ResetCacheAsync(ResetCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ResetCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveTapeArchive

        internal virtual RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeArchiveResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeArchive">REST API Reference for RetrieveTapeArchive Operation</seealso>
        public virtual Task<RetrieveTapeArchiveResponse> RetrieveTapeArchiveAsync(RetrieveTapeArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveTapeRecoveryPoint

        internal virtual RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeRecoveryPointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveTapeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeRecoveryPoint">REST API Reference for RetrieveTapeRecoveryPoint Operation</seealso>
        public virtual Task<RetrieveTapeRecoveryPointResponse> RetrieveTapeRecoveryPointAsync(RetrieveTapeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLocalConsolePassword

        internal virtual SetLocalConsolePasswordResponse SetLocalConsolePassword(SetLocalConsolePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return Invoke<SetLocalConsolePasswordResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetLocalConsolePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetLocalConsolePassword">REST API Reference for SetLocalConsolePassword Operation</seealso>
        public virtual Task<SetLocalConsolePasswordResponse> SetLocalConsolePasswordAsync(SetLocalConsolePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<SetLocalConsolePasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSMBGuestPassword

        internal virtual SetSMBGuestPasswordResponse SetSMBGuestPassword(SetSMBGuestPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSMBGuestPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMBGuestPasswordResponseUnmarshaller.Instance;

            return Invoke<SetSMBGuestPasswordResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetSMBGuestPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSMBGuestPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetSMBGuestPassword">REST API Reference for SetSMBGuestPassword Operation</seealso>
        public virtual Task<SetSMBGuestPasswordResponse> SetSMBGuestPasswordAsync(SetSMBGuestPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSMBGuestPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMBGuestPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<SetSMBGuestPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ShutdownGateway

        internal virtual ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShutdownGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return Invoke<ShutdownGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ShutdownGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ShutdownGateway">REST API Reference for ShutdownGateway Operation</seealso>
        public virtual Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShutdownGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ShutdownGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartGateway

        internal virtual StartGatewayResponse StartGateway(StartGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return Invoke<StartGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartGateway">REST API Reference for StartGateway Operation</seealso>
        public virtual Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<StartGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBandwidthRateLimit

        internal virtual UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateBandwidthRateLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBandwidthRateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimit">REST API Reference for UpdateBandwidthRateLimit Operation</seealso>
        public virtual Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBandwidthRateLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChapCredentials

        internal virtual UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<UpdateChapCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChapCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateChapCredentials">REST API Reference for UpdateChapCredentials Operation</seealso>
        public virtual Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChapCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewayInformation

        internal virtual UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInformationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        public virtual Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewaySoftwareNow

        internal virtual UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewaySoftwareNowResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        public virtual Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewaySoftwareNowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceStartTime

        internal virtual UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceStartTimeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateMaintenanceStartTime">REST API Reference for UpdateMaintenanceStartTime Operation</seealso>
        public virtual Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceStartTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNFSFileShare

        internal virtual UpdateNFSFileShareResponse UpdateNFSFileShare(UpdateNFSFileShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<UpdateNFSFileShareResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNFSFileShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNFSFileShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateNFSFileShare">REST API Reference for UpdateNFSFileShare Operation</seealso>
        public virtual Task<UpdateNFSFileShareResponse> UpdateNFSFileShareAsync(UpdateNFSFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNFSFileShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSMBFileShare

        internal virtual UpdateSMBFileShareResponse UpdateSMBFileShare(UpdateSMBFileShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareResponseUnmarshaller.Instance;

            return Invoke<UpdateSMBFileShareResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSMBFileShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShare">REST API Reference for UpdateSMBFileShare Operation</seealso>
        public virtual Task<UpdateSMBFileShareResponse> UpdateSMBFileShareAsync(UpdateSMBFileShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSMBFileShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSMBFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSMBFileShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSnapshotSchedule

        internal virtual UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSnapshotSchedule">REST API Reference for UpdateSnapshotSchedule Operation</seealso>
        public virtual Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVTLDeviceType

        internal virtual UpdateVTLDeviceTypeResponse UpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateVTLDeviceTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVTLDeviceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateVTLDeviceType">REST API Reference for UpdateVTLDeviceType Operation</seealso>
        public virtual Task<UpdateVTLDeviceTypeResponse> UpdateVTLDeviceTypeAsync(UpdateVTLDeviceTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVTLDeviceTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}