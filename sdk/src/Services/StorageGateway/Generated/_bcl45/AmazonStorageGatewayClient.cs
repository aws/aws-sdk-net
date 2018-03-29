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

using Amazon.StorageGateway.Model;
using Amazon.StorageGateway.Model.Internal.MarshallTransformations;
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
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewayHTTPRequestsHeaders">AWS
    /// Storage Gateway Required Request Headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewaySigningRequests">Signing
    /// Requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#APIErrorResponses">Error
    /// Responses</a>: Provides reference information about AWS Storage Gateway errors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/storagegateway/latest/APIReference/API_Operations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sg_region">AWS Storage
    /// Gateway Regions and Endpoints:</a> Provides a list of each region and endpoints available
    /// for use with AWS Storage Gateway. 
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


        /// <summary>
        /// Activates the gateway you previously deployed on your host. In the activation process,
        /// you specify information such as the region you want to use for storing snapshots or
        /// tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
        /// an activation key, and a name for your gateway. The activation process also associates
        /// your gateway with your account; for more information, see <a>UpdateGatewayInformation</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must turn on the gateway VM before you can activate your gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
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
        public virtual ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request)
        {
            var marshaller = ActivateGatewayRequestMarshaller.Instance;
            var unmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return Invoke<ActivateGatewayRequest,ActivateGatewayResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ActivateGatewayRequestMarshaller.Instance;
            var unmarshaller = ActivateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateGatewayRequest,ActivateGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddCache


        /// <summary>
        /// Configures one or more gateway local disks as cache for a gateway. This operation
        /// is only supported in the cached volume, tape and file gateway type (see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">Storage
        /// Gateway Concepts</a>).
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
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
        public virtual AddCacheResponse AddCache(AddCacheRequest request)
        {
            var marshaller = AddCacheRequestMarshaller.Instance;
            var unmarshaller = AddCacheResponseUnmarshaller.Instance;

            return Invoke<AddCacheRequest,AddCacheResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddCacheRequestMarshaller.Instance;
            var unmarshaller = AddCacheResponseUnmarshaller.Instance;

            return InvokeAsync<AddCacheRequest,AddCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource


        /// <summary>
        /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
        /// which you can use to categorize these resources. For example, you can categorize resources
        /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
        /// you define. You can add tags to the following AWS Storage Gateway resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Storage gateways of all types
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Storage Volumes
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Virtual Tapes
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a maximum of 10 tags for each resource. Virtual tapes and storage volumes
        /// that are recovered to a new gateway maintain their tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
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
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddUploadBuffer


        /// <summary>
        /// Configures one or more gateway local disks as upload buffer for a specified gateway.
        /// This operation is supported for the stored volume, cached volume and tape gateway
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
        public virtual AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request)
        {
            var marshaller = AddUploadBufferRequestMarshaller.Instance;
            var unmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return Invoke<AddUploadBufferRequest,AddUploadBufferResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddUploadBufferRequestMarshaller.Instance;
            var unmarshaller = AddUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<AddUploadBufferRequest,AddUploadBufferResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddWorkingStorage


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
        public virtual AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request)
        {
            var marshaller = AddWorkingStorageRequestMarshaller.Instance;
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<AddWorkingStorageRequest,AddWorkingStorageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddWorkingStorageRequestMarshaller.Instance;
            var unmarshaller = AddWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<AddWorkingStorageRequest,AddWorkingStorageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelArchival


        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated. This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
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
        public virtual CancelArchivalResponse CancelArchival(CancelArchivalRequest request)
        {
            var marshaller = CancelArchivalRequestMarshaller.Instance;
            var unmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return Invoke<CancelArchivalRequest,CancelArchivalResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CancelArchivalRequestMarshaller.Instance;
            var unmarshaller = CancelArchivalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelArchivalRequest,CancelArchivalResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelRetrieval


        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
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
        public virtual CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request)
        {
            var marshaller = CancelRetrievalRequestMarshaller.Instance;
            var unmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return Invoke<CancelRetrievalRequest,CancelRetrievalResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CancelRetrievalRequestMarshaller.Instance;
            var unmarshaller = CancelRetrievalResponseUnmarshaller.Instance;

            return InvokeAsync<CancelRetrievalRequest,CancelRetrievalResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCachediSCSIVolume


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
        /// Optionally, you can provide the ARN for an existing volume as the <code>SourceVolumeARN</code>
        /// for this cached volume, which creates an exact copy of the existing volume’s latest
        /// recovery point. The <code>VolumeSizeInBytes</code> value must be equal to or larger
        /// than the size of the copied volume, in bytes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
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
        public virtual CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request)
        {
            var marshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateCachediSCSIVolumeRequest,CreateCachediSCSIVolumeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateCachediSCSIVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateCachediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCachediSCSIVolumeRequest,CreateCachediSCSIVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNFSFileShare


        /// <summary>
        /// Creates a file share on an existing file gateway. In Storage Gateway, a file share
        /// is a file system mount point backed by Amazon S3 cloud storage. Storage Gateway exposes
        /// file shares using a Network File System (NFS) interface. This operation is only supported
        /// in the file gateway type.
        /// 
        ///  <important> 
        /// <para>
        /// File gateway requires AWS Security Token Service (AWS STS) to be activated to enable
        /// you create a file share. Make sure AWS STS is activated in the region you are creating
        /// your file gateway in. If AWS STS is not activated in the region, activate it. For
        /// information about how to activate AWS STS, see Activating and Deactivating AWS STS
        /// in an AWS Region in the AWS Identity and Access Management User Guide. 
        /// </para>
        ///  
        /// <para>
        /// File gateway does not support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNFSFileShare service method.</param>
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
        public virtual CreateNFSFileShareResponse CreateNFSFileShare(CreateNFSFileShareRequest request)
        {
            var marshaller = CreateNFSFileShareRequestMarshaller.Instance;
            var unmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<CreateNFSFileShareRequest,CreateNFSFileShareResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateNFSFileShareRequestMarshaller.Instance;
            var unmarshaller = CreateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNFSFileShareRequest,CreateNFSFileShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway provides the ability to back up point-in-time snapshots of your
        /// data to Amazon Simple Storage (S3) for durable off-site recovery, as well as import
        /// the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute Cloud
        /// (EC2). You can take snapshots of your gateway volume on a scheduled or ad-hoc basis.
        /// This API enables you to take ad-hoc snapshot. For more information, see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#SchedulingSnapshot">Editing
        /// a Snapshot Schedule</a>.
        /// </para>
        ///  
        /// <para>
        /// In the CreateSnapshot request you identify the volume by providing its Amazon Resource
        /// Name (ARN). You must also provide description for the snapshot. When AWS Storage Gateway
        /// takes the snapshot of specified volume, the snapshot and description appears in the
        /// AWS Storage Gateway Console. In response, AWS Storage Gateway returns you a snapshot
        /// ID. You can use this snapshot ID to check the snapshot progress or later use it when
        /// you want to create a volume from a snapshot. This operation is only supported in stored
        /// and cached volume gateway type.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see DescribeSnapshots or DeleteSnapshot in the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_Operations.html">EC2
        /// API reference</a>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Volume and snapshot IDs are changing to a longer length ID format. For more information,
        /// see the important note on the <a href="http://docs.aws.amazon.com/storagegateway/latest/APIReference/Welcome.html">Welcome</a>
        /// page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
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
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint


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
        /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
        /// for the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
        /// and its description appear in the AWS Storage Gateway console. In response, the gateway
        /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
        /// or later use it when you want to create a volume from a snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// in <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
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
        public virtual CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request)
        {
            var marshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotFromVolumeRecoveryPointRequest,CreateSnapshotFromVolumeRecoveryPointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSnapshotFromVolumeRecoveryPointRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotFromVolumeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotFromVolumeRecoveryPointRequest,CreateSnapshotFromVolumeRecoveryPointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStorediSCSIVolume


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
        /// In the request you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, the gateway creates the volume and returns volume
        /// information such as the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
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
        public virtual CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request)
        {
            var marshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateStorediSCSIVolumeRequest,CreateStorediSCSIVolumeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateStorediSCSIVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateStorediSCSIVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorediSCSIVolumeRequest,CreateStorediSCSIVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTapes


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
        public virtual CreateTapesResponse CreateTapes(CreateTapesRequest request)
        {
            var marshaller = CreateTapesRequestMarshaller.Instance;
            var unmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return Invoke<CreateTapesRequest,CreateTapesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateTapesRequestMarshaller.Instance;
            var unmarshaller = CreateTapesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapesRequest,CreateTapesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTapeWithBarcode


        /// <summary>
        /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
        /// and then archive the tape. A barcode is unique and can not be reused if it has already
        /// been used on a tape . This applies to barcodes used on deleted tapes. This operation
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
        public virtual CreateTapeWithBarcodeResponse CreateTapeWithBarcode(CreateTapeWithBarcodeRequest request)
        {
            var marshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            var unmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return Invoke<CreateTapeWithBarcodeRequest,CreateTapeWithBarcodeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateTapeWithBarcodeRequestMarshaller.Instance;
            var unmarshaller = CreateTapeWithBarcodeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTapeWithBarcodeRequest,CreateTapeWithBarcodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBandwidthRateLimit


        /// <summary>
        /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
        /// download bandwidth rate limit, or you can delete both. If you delete only one of the
        /// limits, the other limit remains unchanged. To specify which gateway to work with,
        /// use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
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
        public virtual DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request)
        {
            var marshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteBandwidthRateLimitRequest,DeleteBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = DeleteBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBandwidthRateLimitRequest,DeleteBandwidthRateLimitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteChapCredentials


        /// <summary>
        /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target and initiator pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
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
        public virtual DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request)
        {
            var marshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteChapCredentialsRequest,DeleteChapCredentialsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = DeleteChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChapCredentialsRequest,DeleteChapCredentialsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileShare


        /// <summary>
        /// Deletes a file share from a file gateway. This operation is only supported in the
        /// file gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileShare service method.</param>
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
        public virtual DeleteFileShareResponse DeleteFileShare(DeleteFileShareRequest request)
        {
            var marshaller = DeleteFileShareRequestMarshaller.Instance;
            var unmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return Invoke<DeleteFileShareRequest,DeleteFileShareResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteFileShareRequestMarshaller.Instance;
            var unmarshaller = DeleteFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileShareRequest,DeleteFileShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGateway


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
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">
        /// AWS Storage Gateway Detail Page</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
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
        public virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var marshaller = DeleteGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayRequest,DeleteGatewayResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayRequest,DeleteGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotSchedule


        /// <summary>
        /// Deletes a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// You can take snapshots of your gateway volumes on a scheduled or ad hoc basis. This
        /// API action enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
        /// with Snapshots</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
        /// the volume by providing its Amazon Resource Name (ARN). This operation is only supported
        /// in stored and cached volume gateway types.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. in <i>Amazon Elastic
        /// Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
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
        public virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var marshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleRequest,DeleteSnapshotScheduleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotScheduleRequest,DeleteSnapshotScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTape


        /// <summary>
        /// Deletes the specified virtual tape. This operation is only supported in the tape gateway
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
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
        public virtual DeleteTapeResponse DeleteTape(DeleteTapeRequest request)
        {
            var marshaller = DeleteTapeRequestMarshaller.Instance;
            var unmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeRequest,DeleteTapeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTapeRequestMarshaller.Instance;
            var unmarshaller = DeleteTapeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeRequest,DeleteTapeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTapeArchive


        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS). This operation
        /// is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
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
        public virtual DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request)
        {
            var marshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            var unmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteTapeArchiveRequest,DeleteTapeArchiveResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTapeArchiveRequestMarshaller.Instance;
            var unmarshaller = DeleteTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTapeArchiveRequest,DeleteTapeArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume


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
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
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
        public virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = DeleteVolumeRequestMarshaller.Instance;
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteVolumeRequestMarshaller.Instance;
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBandwidthRateLimit


        /// <summary>
        /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
        /// which means no bandwidth rate limiting is in effect.
        /// 
        ///  
        /// <para>
        /// This operation only returns a value for a bandwidth rate limit only if the limit is
        /// set. If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
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
        public virtual DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request)
        {
            var marshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<DescribeBandwidthRateLimitRequest,DescribeBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = DescribeBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBandwidthRateLimitRequest,DescribeBandwidthRateLimitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCache


        /// <summary>
        /// Returns information about the cache of a gateway. This operation is only supported
        /// in the cached volume, tape and file gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as cache, and it includes the amount
        /// of cache allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
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
        public virtual DescribeCacheResponse DescribeCache(DescribeCacheRequest request)
        {
            var marshaller = DescribeCacheRequestMarshaller.Instance;
            var unmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheRequest,DescribeCacheResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeCacheRequestMarshaller.Instance;
            var unmarshaller = DescribeCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheRequest,DescribeCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCachediSCSIVolumes


        /// <summary>
        /// Returns a description of the gateway volumes specified in the request. This operation
        /// is only supported in the cached volume gateway types.
        /// 
        ///  
        /// <para>
        /// The list of gateway volumes in the request must be from one gateway. In the response
        /// Amazon Storage Gateway returns volume information sorted by volume Amazon Resource
        /// Name (ARN).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
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
        public virtual DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request)
        {
            var marshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeCachediSCSIVolumesRequest,DescribeCachediSCSIVolumesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeCachediSCSIVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeCachediSCSIVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCachediSCSIVolumesRequest,DescribeCachediSCSIVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeChapCredentials


        /// <summary>
        /// Returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// information for a specified iSCSI target, one for each target-initiator pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
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
        public virtual DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request)
        {
            var marshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<DescribeChapCredentialsRequest,DescribeChapCredentialsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = DescribeChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChapCredentialsRequest,DescribeChapCredentialsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGatewayInformation


        /// <summary>
        /// Returns metadata about a gateway such as its name, network interfaces, configured
        /// time zone, and the state (whether the gateway is running or not). To specify which
        /// gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
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
        public virtual DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request)
        {
            var marshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInformationRequest,DescribeGatewayInformationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeGatewayInformationRequestMarshaller.Instance;
            var unmarshaller = DescribeGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayInformationRequest,DescribeGatewayInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceStartTime


        /// <summary>
        /// Returns your gateway's weekly maintenance start time including the day and time of
        /// the week. Note that values are in terms of the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
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
        public virtual DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request)
        {
            var marshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceStartTimeRequest,DescribeMaintenanceStartTimeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeMaintenanceStartTimeRequestMarshaller.Instance;
            var unmarshaller = DescribeMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceStartTimeRequest,DescribeMaintenanceStartTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNFSFileShares


        /// <summary>
        /// Gets a description for one or more file shares from a file gateway. This operation
        /// is only supported in the file gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNFSFileShares service method.</param>
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
        public virtual DescribeNFSFileSharesResponse DescribeNFSFileShares(DescribeNFSFileSharesRequest request)
        {
            var marshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            var unmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeNFSFileSharesRequest,DescribeNFSFileSharesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeNFSFileSharesRequestMarshaller.Instance;
            var unmarshaller = DescribeNFSFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNFSFileSharesRequest,DescribeNFSFileSharesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotSchedule


        /// <summary>
        /// Describes the snapshot schedule for the specified gateway volume. The snapshot schedule
        /// information includes intervals at which snapshots are automatically initiated on the
        /// volume. This operation is only supported in the cached volume and stored volume types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
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
        public virtual DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request)
        {
            var marshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotScheduleRequest,DescribeSnapshotScheduleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotScheduleRequest,DescribeSnapshotScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorediSCSIVolumes


        /// <summary>
        /// Returns the description of the gateway volumes specified in the request. The list
        /// of gateway volumes in the request must be from one gateway. In the response Amazon
        /// Storage Gateway returns volume information sorted by volume ARNs. This operation is
        /// only supported in stored volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
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
        public virtual DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request)
        {
            var marshaller = DescribeStorediSCSIVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorediSCSIVolumesRequest,DescribeStorediSCSIVolumesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeStorediSCSIVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeStorediSCSIVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorediSCSIVolumesRequest,DescribeStorediSCSIVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTapeArchives


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
        public virtual DescribeTapeArchivesResponse DescribeTapeArchives()
        {
            return DescribeTapeArchives(new DescribeTapeArchivesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
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
        public virtual DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request)
        {
            var marshaller = DescribeTapeArchivesRequestMarshaller.Instance;
            var unmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeArchivesRequest,DescribeTapeArchivesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTapeArchivesRequestMarshaller.Instance;
            var unmarshaller = DescribeTapeArchivesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeArchivesRequest,DescribeTapeArchivesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTapeRecoveryPoints


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
        public virtual DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request)
        {
            var marshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            var unmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<DescribeTapeRecoveryPointsRequest,DescribeTapeRecoveryPointsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTapeRecoveryPointsRequestMarshaller.Instance;
            var unmarshaller = DescribeTapeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapeRecoveryPointsRequest,DescribeTapeRecoveryPointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTapes


        /// <summary>
        /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
        /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
        /// associated with the specified gateway. This operation is only supported in the tape
        /// gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
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
        public virtual DescribeTapesResponse DescribeTapes(DescribeTapesRequest request)
        {
            var marshaller = DescribeTapesRequestMarshaller.Instance;
            var unmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return Invoke<DescribeTapesRequest,DescribeTapesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTapesRequestMarshaller.Instance;
            var unmarshaller = DescribeTapesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTapesRequest,DescribeTapesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUploadBuffer


        /// <summary>
        /// Returns information about the upload buffer of a gateway. This operation is supported
        /// for the stored volume, cached volume and tape gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
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
        public virtual DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request)
        {
            var marshaller = DescribeUploadBufferRequestMarshaller.Instance;
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return Invoke<DescribeUploadBufferRequest,DescribeUploadBufferResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeUploadBufferRequestMarshaller.Instance;
            var unmarshaller = DescribeUploadBufferResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUploadBufferRequest,DescribeUploadBufferResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVTLDevices


        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified tape
        /// gateway. In the response, AWS Storage Gateway returns VTL device information.
        /// 
        ///  
        /// <para>
        /// This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
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
        public virtual DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request)
        {
            var marshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVTLDevicesRequest,DescribeVTLDevicesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeVTLDevicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVTLDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVTLDevicesRequest,DescribeVTLDevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkingStorage


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
        public virtual DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request)
        {
            var marshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkingStorageRequest,DescribeWorkingStorageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeWorkingStorageRequestMarshaller.Instance;
            var unmarshaller = DescribeWorkingStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkingStorageRequest,DescribeWorkingStorageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableGateway


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
        /// Once a gateway is disabled it cannot be enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
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
        public virtual DisableGatewayResponse DisableGateway(DisableGatewayRequest request)
        {
            var marshaller = DisableGatewayRequestMarshaller.Instance;
            var unmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return Invoke<DisableGatewayRequest,DisableGatewayResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisableGatewayRequestMarshaller.Instance;
            var unmarshaller = DisableGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DisableGatewayRequest,DisableGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFileShares


        /// <summary>
        /// Gets a list of the file shares for a specific file gateway, or the list of file shares
        /// that belong to the calling user account. This operation is only supported in the file
        /// gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileShares service method.</param>
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
        public virtual ListFileSharesResponse ListFileShares(ListFileSharesRequest request)
        {
            var marshaller = ListFileSharesRequestMarshaller.Instance;
            var unmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return Invoke<ListFileSharesRequest,ListFileSharesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListFileSharesRequestMarshaller.Instance;
            var unmarshaller = ListFileSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFileSharesRequest,ListFileSharesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGateways


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
        public virtual ListGatewaysResponse ListGateways()
        {
            return ListGateways(new ListGatewaysRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
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
        public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var marshaller = ListGatewaysRequestMarshaller.Instance;
            var unmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysRequest,ListGatewaysResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListGatewaysRequestMarshaller.Instance;
            var unmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysRequest,ListGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLocalDisks


        /// <summary>
        /// Returns a list of the gateway's local disks. To specify which gateway to describe,
        /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
        /// 
        ///  
        /// <para>
        /// The request returns a list of all disks, specifying which are configured as working
        /// storage, cache storage, or stored volume or not configured at all. The response includes
        /// a <code>DiskStatus</code> field. This field can have a value of present (the disk
        /// is available to use), missing (the disk is no longer connected to the gateway), or
        /// mismatch (the disk node is occupied by a disk that has incorrect metadata or the disk
        /// content is corrupted).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
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
        public virtual ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request)
        {
            var marshaller = ListLocalDisksRequestMarshaller.Instance;
            var unmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return Invoke<ListLocalDisksRequest,ListLocalDisksResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListLocalDisksRequestMarshaller.Instance;
            var unmarshaller = ListLocalDisksResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocalDisksRequest,ListLocalDisksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that have been added to the specified resource. This operation is only
        /// supported in the cached volume, stored volume and tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTapes


        /// <summary>
        /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
        /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
        /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
        /// in both your VTL and VTS.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <code>Limit</code> parameter in the
        /// body to limit the number of tapes in the response. If the number of tapes returned
        /// in the response is truncated, the response includes a <code>Marker</code> element
        /// that you can use in your subsequent request to retrieve the next set of tapes. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapes service method.</param>
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
        public virtual ListTapesResponse ListTapes(ListTapesRequest request)
        {
            var marshaller = ListTapesRequestMarshaller.Instance;
            var unmarshaller = ListTapesResponseUnmarshaller.Instance;

            return Invoke<ListTapesRequest,ListTapesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTapesRequestMarshaller.Instance;
            var unmarshaller = ListTapesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTapesRequest,ListTapesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVolumeInitiators


        /// <summary>
        /// Lists iSCSI initiators that are connected to a volume. You can use this operation
        /// to determine whether a volume is being used or not. This operation is only supported
        /// in the cached volume and stored volume gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators service method.</param>
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
        public virtual ListVolumeInitiatorsResponse ListVolumeInitiators(ListVolumeInitiatorsRequest request)
        {
            var marshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            var unmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeInitiatorsRequest,ListVolumeInitiatorsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListVolumeInitiatorsRequestMarshaller.Instance;
            var unmarshaller = ListVolumeInitiatorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeInitiatorsRequest,ListVolumeInitiatorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVolumeRecoveryPoints


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
        public virtual ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request)
        {
            var marshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListVolumeRecoveryPointsRequest,ListVolumeRecoveryPointsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListVolumeRecoveryPointsRequestMarshaller.Instance;
            var unmarshaller = ListVolumeRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumeRecoveryPointsRequest,ListVolumeRecoveryPointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVolumes


        /// <summary>
        /// Lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The
        /// response includes only the volume ARNs. If you want additional volume information,
        /// use the <a>DescribeStorediSCSIVolumes</a> or the <a>DescribeCachediSCSIVolumes</a>
        /// API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <code>Limit</code> field in the
        /// body to limit the number of volumes in the response. If the number of volumes returned
        /// in the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes. This
        /// operation is only supported in the cached volume and stored volume gateway types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
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
        public virtual ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            var marshaller = ListVolumesRequestMarshaller.Instance;
            var unmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return Invoke<ListVolumesRequest,ListVolumesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListVolumesRequestMarshaller.Instance;
            var unmarshaller = ListVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVolumesRequest,ListVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  NotifyWhenUploaded


        /// <summary>
        /// Sends you notification through CloudWatch Events when all files written to your NFS
        /// file share have been uploaded to Amazon S3.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway can send a notification through Amazon CloudWatch Events when
        /// all files written to your file share up to that point in time have been uploaded to
        /// Amazon S3. These files include files written to the NFS file share up to the time
        /// that you make a request for notification. When the upload is done, Storage Gateway
        /// sends you notification through an Amazon CloudWatch Event. You can configure CloudWatch
        /// Events to send the notification through event targets such as Amazon SNS or AWS Lambda
        /// function. This operation is only supported in the file gateway type.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Getting File Upload Notification in the Storage Gateway
        /// User Guide (https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-upload-notification).
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWhenUploaded service method.</param>
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
        public virtual NotifyWhenUploadedResponse NotifyWhenUploaded(NotifyWhenUploadedRequest request)
        {
            var marshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            var unmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return Invoke<NotifyWhenUploadedRequest,NotifyWhenUploadedResponse>(request, marshaller, unmarshaller);
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
            var marshaller = NotifyWhenUploadedRequestMarshaller.Instance;
            var unmarshaller = NotifyWhenUploadedResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyWhenUploadedRequest,NotifyWhenUploadedResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RefreshCache


        /// <summary>
        /// Refreshes the cache for the specified file share. This operation finds objects in
        /// the Amazon S3 bucket that were added, removed or replaced since the gateway last listed
        /// the bucket's contents and cached the results. This operation is only supported in
        /// the file gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshCache service method.</param>
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
        public virtual RefreshCacheResponse RefreshCache(RefreshCacheRequest request)
        {
            var marshaller = RefreshCacheRequestMarshaller.Instance;
            var unmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return Invoke<RefreshCacheRequest,RefreshCacheResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RefreshCacheRequestMarshaller.Instance;
            var unmarshaller = RefreshCacheResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshCacheRequest,RefreshCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes one or more tags from the specified resource. This operation is only supported
        /// in the cached volume, stored volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
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
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetCache


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
        public virtual ResetCacheResponse ResetCache(string gatewayARN)
        {
            var request = new ResetCacheRequest();
            request.GatewayARN = gatewayARN;
            return ResetCache(request);
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
        /// <param name="request">Container for the necessary parameters to execute the ResetCache service method.</param>
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
        public virtual ResetCacheResponse ResetCache(ResetCacheRequest request)
        {
            var marshaller = ResetCacheRequestMarshaller.Instance;
            var unmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return Invoke<ResetCacheRequest,ResetCacheResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ResetCacheRequestMarshaller.Instance;
            var unmarshaller = ResetCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ResetCacheRequest,ResetCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetrieveTapeArchive


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
        public virtual RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request)
        {
            var marshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            var unmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeArchiveRequest,RetrieveTapeArchiveResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RetrieveTapeArchiveRequestMarshaller.Instance;
            var unmarshaller = RetrieveTapeArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeArchiveRequest,RetrieveTapeArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetrieveTapeRecoveryPoint


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
        public virtual RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request)
        {
            var marshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            var unmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RetrieveTapeRecoveryPointRequest,RetrieveTapeRecoveryPointResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RetrieveTapeRecoveryPointRequestMarshaller.Instance;
            var unmarshaller = RetrieveTapeRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveTapeRecoveryPointRequest,RetrieveTapeRecoveryPointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLocalConsolePassword


        /// <summary>
        /// Sets the password for your VM local console. When you log in to the local console
        /// for the first time, you log in to the VM with the default credentials. We recommend
        /// that you set a new password. You don't need to know the default password to set a
        /// new password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword service method.</param>
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
        public virtual SetLocalConsolePasswordResponse SetLocalConsolePassword(SetLocalConsolePasswordRequest request)
        {
            var marshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            var unmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return Invoke<SetLocalConsolePasswordRequest,SetLocalConsolePasswordResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SetLocalConsolePasswordRequestMarshaller.Instance;
            var unmarshaller = SetLocalConsolePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<SetLocalConsolePasswordRequest,SetLocalConsolePasswordResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ShutdownGateway


        /// <summary>
        /// Shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource
        /// Name (ARN) of the gateway in the body of your request.
        /// 
        ///  
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
        /// When you make a shutdown request, you will get a <code>200 OK</code> success response
        /// immediately. However, it might take some time for the gateway to shut down. You can
        /// call the <a>DescribeGatewayInformation</a> API to check the status. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
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
        public virtual ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request)
        {
            var marshaller = ShutdownGatewayRequestMarshaller.Instance;
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return Invoke<ShutdownGatewayRequest,ShutdownGatewayResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ShutdownGatewayRequestMarshaller.Instance;
            var unmarshaller = ShutdownGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<ShutdownGatewayRequest,ShutdownGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartGateway


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
        public virtual StartGatewayResponse StartGateway(StartGatewayRequest request)
        {
            var marshaller = StartGatewayRequestMarshaller.Instance;
            var unmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return Invoke<StartGatewayRequest,StartGatewayResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartGatewayRequestMarshaller.Instance;
            var unmarshaller = StartGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<StartGatewayRequest,StartGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBandwidthRateLimit


        /// <summary>
        /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
        /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
        /// rate limit, the existing rate limit remains.
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
        public virtual UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request)
        {
            var marshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateBandwidthRateLimitRequest,UpdateBandwidthRateLimitResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateBandwidthRateLimitRequestMarshaller.Instance;
            var unmarshaller = UpdateBandwidthRateLimitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBandwidthRateLimitRequest,UpdateBandwidthRateLimitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateChapCredentials


        /// <summary>
        /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
        /// security, you might use it.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
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
        public virtual UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request)
        {
            var marshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return Invoke<UpdateChapCredentialsRequest,UpdateChapCredentialsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateChapCredentialsRequestMarshaller.Instance;
            var unmarshaller = UpdateChapCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChapCredentialsRequest,UpdateChapCredentialsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewayInformation


        /// <summary>
        /// Updates a gateway's metadata, which includes the gateway's name and time zone. To
        /// specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// 
        ///  <note> 
        /// <para>
        /// For Gateways activated after September 2, 2015, the gateway's ARN contains the gateway
        /// ID rather than the gateway name. However, changing the name of the gateway has no
        /// effect on the gateway's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
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
        public virtual UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var marshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInformationRequest,UpdateGatewayInformationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayInformationRequest,UpdateGatewayInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewaySoftwareNow


        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
        /// to verify the gateway is in the <code>STATE_RUNNING</code> state.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A software update forces a system restart of your gateway. You can minimize the chance
        /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
        /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
        /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// Your Windows iSCSI Settings</a> and <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// Your Linux iSCSI Settings</a>, respectively.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
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
        public virtual UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var marshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewaySoftwareNowRequest,UpdateGatewaySoftwareNowResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewaySoftwareNowRequest,UpdateGatewaySoftwareNowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceStartTime


        /// <summary>
        /// Updates a gateway's weekly maintenance start time information, including day and time
        /// of the week. The maintenance time is the time in your gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
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
        public virtual UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request)
        {
            var marshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceStartTimeRequest,UpdateMaintenanceStartTimeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateMaintenanceStartTimeRequestMarshaller.Instance;
            var unmarshaller = UpdateMaintenanceStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceStartTimeRequest,UpdateMaintenanceStartTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateNFSFileShare


        /// <summary>
        /// Updates a file share. This operation is only supported in the file gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the following file share setting:
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
        ///  </li> </ul> <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// This operation is only supported in file gateways.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNFSFileShare service method.</param>
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
        public virtual UpdateNFSFileShareResponse UpdateNFSFileShare(UpdateNFSFileShareRequest request)
        {
            var marshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            var unmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return Invoke<UpdateNFSFileShareRequest,UpdateNFSFileShareResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateNFSFileShareRequestMarshaller.Instance;
            var unmarshaller = UpdateNFSFileShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNFSFileShareRequest,UpdateNFSFileShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSnapshotSchedule


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
        public virtual UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request)
        {
            var marshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotScheduleRequest,UpdateSnapshotScheduleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateSnapshotScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotScheduleRequest,UpdateSnapshotScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVTLDeviceType


        /// <summary>
        /// Updates the type of medium changer in a tape gateway. When you activate a tape gateway,
        /// you select a medium changer type for the tape gateway. This operation enables you
        /// to select a different type of medium changer after a tape gateway is activated. This
        /// operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType service method.</param>
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
        public virtual UpdateVTLDeviceTypeResponse UpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request)
        {
            var marshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateVTLDeviceTypeRequest,UpdateVTLDeviceTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateVTLDeviceTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateVTLDeviceTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVTLDeviceTypeRequest,UpdateVTLDeviceTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}